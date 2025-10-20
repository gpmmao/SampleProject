using Common;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
	[AutoRegister]
	public class GetOderService : IGetOrderService
	{
		public OrderDto GetOrder(int orderId) {
			return OrderStore.productList.Find(o => o.OrderId == orderId);
		}

		public IEnumerable<OrderDto> GetOrders() {
			List<OrderDto> orders = OrderStore.productList;
			return orders;
		}
	}
}
