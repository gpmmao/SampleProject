using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models.Products;

namespace WebApi.Models
{
	public class ProductData
	{
        public ProductData(string name, string description, decimal price) 
        {
            Name =name;
            Description = description;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}