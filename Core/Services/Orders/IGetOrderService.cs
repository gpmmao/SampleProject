using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
	public interface IGetOrderService
	{
		OrderDto GetOrder(int orderId);

		IEnumerable<OrderDto> GetOrders();
	}
}
