using System;
using System.Collections.Generic;
using System.Text;
using Data.Repositories;

namespace Core.Services.Products
{
	public interface IGetProductService
	{
		ProductDto GetProduct(int id);

		IEnumerable<ProductDto> GetProducts();
	}
}
