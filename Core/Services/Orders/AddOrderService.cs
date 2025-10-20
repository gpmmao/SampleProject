using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Common;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class AddOrderService : IAddOrderService
	{
        public OrderDto AddProduct(ProductDto product)
        {
            OrderDto newOne = new OrderDto();
            var orderid = OrderStore.productList.Max(prod => prod.OrderId) + 1;
            var newProd = new OrderDto { OrderId = orderid,Product = product };
            OrderStore.productList.Add(newProd);
            return newProd;
        }
    }
}
