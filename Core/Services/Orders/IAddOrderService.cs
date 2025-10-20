using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
	public interface IAddOrderService
	{
		 OrderDto AddProduct(ProductDto prod);
	}
}
