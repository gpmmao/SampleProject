using Common;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class UpdateOrderService : IUpdateOrderService
	{
        public void Update(int orderId, ProductDto product)
        {
            OrderDto origOrder = OrderStore.productList.Find(p => p.OrderId  == orderId);
            if (origOrder != null)
            {
                origOrder.Product.Name = product.Name;
                origOrder.Product.Description = product.Description;
                origOrder.Product.Price = product.Price;
            }
        }
    }
}
