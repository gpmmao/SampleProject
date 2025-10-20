using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
	public interface IUpdateOrderService
	{
		void Update(int orderId, ProductDto product);
	}
}
