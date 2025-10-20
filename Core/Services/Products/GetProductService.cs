using Common;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Products
{
	[AutoRegister]
	public class GetProductService : IGetProductService
	{
		public ProductDto GetProduct(int id) { 
			return ProductStore.productList.Find(p => p.Id == id);
		}

		public IEnumerable<ProductDto> GetProducts()
		{
			List<ProductDto> products = ProductStore.productList;
			return products;
		}
	}
}
