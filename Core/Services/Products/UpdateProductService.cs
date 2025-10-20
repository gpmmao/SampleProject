using System.Collections.Generic;
using System.Linq;
using BusinessEntities;
using Common;
using Data.Repositories;

namespace Core.Services.Products
{
    [AutoRegister(AutoRegisterTypes.Singleton)]
    public class UpdateProductService : IUpdateProductService
    {
        public void  Update(int id, string name, string description, decimal price)
        {
            var product = ProductStore.productList.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                product.Name = name;
                product.Description = description;
                product.Price = price;
            }
           // ProductStore.productList.Add(new ProductDto { Id = id, Name = name, Description = description, Price = price });
        }
    }
}