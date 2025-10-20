using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
	public class OrderDto
	{
		public int OrderId { get; set; }
		public ProductDto Product { get;set;}
	}
}
