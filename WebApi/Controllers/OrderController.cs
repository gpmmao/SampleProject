using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi.Models.Products;
using WebApi.Models;
using Core.Services.Orders;
using System.Net.Http;
using WebApi.Models.Orders;
using Data.Repositories;

namespace WebApi.Controllers
{
	[RoutePrefix("orders")]
	public class OrderController : BaseApiController
	{
		private readonly IAddOrderService _addOrderService;
		private readonly IDeleteOrderService _deleteOrderService;
		private readonly IGetOrderService _getOrderService;
		private readonly IUpdateOrderService _updateOrderService;

		public OrderController(IAddOrderService addOrderService, IDeleteOrderService deleteOrderService, IGetOrderService getOrderService, IUpdateOrderService updateOrderService)
		{
			_addOrderService = addOrderService;
			_deleteOrderService = deleteOrderService;
			_getOrderService = getOrderService;
			_updateOrderService = updateOrderService;
		}

		[Route("create")]
		[HttpPost]
		public HttpResponseMessage AddOrder([FromBody] Product model)
		{
			var product = new ProductDto { Id = model.Id, Name = model.Name, Description = model.Description, Price = model.Price };
			
			_addOrderService.AddProduct(product);
			return Found(product);
		}

		[Route("{orderId:int}")]
		[HttpGet]
		public HttpResponseMessage GetOrder(int orderId)
		{
			var order = _getOrderService.GetOrder(orderId);
			if (order == null)
			{
				return DoesNotExist();
			}
			return Found(new OrderDto { OrderId = orderId, Product = order.Product });
		}

		[Route("list")]
		[HttpGet]
		public HttpResponseMessage GetAllOrders()
		{
			var orders = _getOrderService.GetOrders();
			return Found(orders);
		}

		[Route("{orderId:int}/update")]
		[HttpPut]
		public HttpResponseMessage UpdateOrder(int orderId, [FromBody] Product model)
		{
			var order = _getOrderService.GetOrder(orderId);
			if (order == null)
			{
				return DoesNotExist();
			}
			_updateOrderService.Update(orderId, order.Product);
			return Found(new OrderDto { OrderId = orderId, Product = order.Product });
		}

		[Route("{orderId:int}/delete")]
		[HttpDelete]
		public HttpResponseMessage DeleteProduct(int orderId)
		{
			var order = _getOrderService.GetOrder(orderId);
			if (order == null)
			{
				return DoesNotExist();
			}
			_deleteOrderService.Delete(orderId);
			return Found();
		}


		[Route("clear")]
		[HttpDelete]
		public HttpResponseMessage DeleteAllOrders()
		{
			_deleteOrderService.DeleteAll();
			return Found();
		}

	}
}