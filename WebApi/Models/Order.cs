using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models.Orders
{
	public class Order
	{
        public int orderId { get; set; }
        public ProductData produc { get; set; }
	}
}