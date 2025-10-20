using Core.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using System.Web.Http;
using BusinessEntities;
using Core.Services.Users;
using WebApi.Models.Products;
using WebApi.Models;
using Data.Repositories;

namespace WebApi.Controllers
{
    [RoutePrefix("products")]
    public class ProductController : BaseApiController
    {
		private readonly ICreateProductService _createProductService;
		private readonly IDeleteProductService _deleteProductService;
		private readonly IGetProductService _getProductService;
        private readonly IUpdateProductService _updateProductService;
        public ProductController(ICreateProductService createProductService, IDeleteProductService deleteProductService, IGetProductService getProductService, IUpdateProductService updateProductService)
        {
            _createProductService = createProductService;
            _deleteProductService = deleteProductService;
            _getProductService = getProductService;
            _updateProductService = updateProductService;
        }

        [Route("create")]
        [HttpPost]
        public HttpResponseMessage CreateProduct( [FromBody] Product model)
        {
           // ProductDto Create(string name, string description, decimal price);
            var product = _createProductService.Create(model.Name, model.Description, model.Price);
            return  Found(new ProductData(model.Name, model.Description, model.Price));
        }

        [Route("{prodId:int}/update")]
        [HttpPut]
        public HttpResponseMessage UpdateProductr(int prodId, [FromBody] Product model)
        {
            var product = _getProductService.GetProduct(model.Id);
            if (product == null)
            {
                return DoesNotExist();
            }
            _updateProductService.Update(prodId, model.Name, model.Description, model.Price);
            return Found(new ProductData(model.Name, model.Description, model.Price));
        }

        [Route("{prodId:int}/delete")]
        [HttpDelete]
        public HttpResponseMessage DeleteProduct(int productId)
        {
            var product = _getProductService.GetProduct(productId);
            if (product == null)
            {
                return DoesNotExist();
            }
            _deleteProductService.Delete(productId);
            return Found();
        }

        [Route("{productId:int}")]
        [HttpGet]
        public HttpResponseMessage GetProduct(int productId)
        {
            var product = _getProductService.GetProduct(productId);
            if (product == null)
            {
                return DoesNotExist();
            }
            return Found(new ProductData(product.Name, product.Description, product.Price));
        }

        [Route("list")]
        [HttpGet]
        public HttpResponseMessage GetAllProducts()
        {
            var productsList = _getProductService.GetProducts();
            return Found(productsList);
        }

        [Route("clear")]
        [HttpDelete]
        public HttpResponseMessage DeleteAllProducts()
        {
            _deleteProductService.DeleteAll();
            return Found();
        }
    }
}