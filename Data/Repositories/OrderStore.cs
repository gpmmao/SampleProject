using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data.Repositories
{
	public class OrderStore
	{
		public static List<OrderDto> productList = new List<OrderDto>
		{

			new OrderDto {
				OrderId = 1, Product = new ProductDto
				{
					Id = 1,
					Name = "Dell Laptop",
					Description = "test one only",
					Price = 1220.08M
				}
			}

		};

		int largestOrderId = productList.Max(o => o.OrderId);
	}
}

