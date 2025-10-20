using System;
using System.Collections.Generic;
using System.Text;


namespace Data.Repositories
{
	public class ProductStore
	{
		public static List<ProductDto> productList = new List<ProductDto>
		{
			new ProductDto { Id = 1, Name ="Dell Laptop" , Description="test one only", Price = 1220.08M},
			new ProductDto { Id = 2, Name ="Wireless Mouse" , Description="Ergonomic wireless mouse with USB receiver", Price = 10.00M},
			new ProductDto { Id = 3, Name ="Dell Keyboard" , Description="keyboard with blue switches", Price = 20.08M},
			new ProductDto { Id = 4, Name ="Dell 4K Monitor" , Description="test one only", Price = 120.08M},
		};
	}
}
