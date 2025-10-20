using Common;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class DeleteOrderService : IDeleteOrderService
	{
        public void Delete(int orderId)
        {
            var order = OrderStore.productList.Find(p => p.OrderId == orderId);
            if (order != null)
                OrderStore.productList.Remove(order);
        }

        public void DeleteAll()
        {
            // set Order producList to new empty list
            OrderStore.productList = new List<OrderDto>();
        }
    }
}
