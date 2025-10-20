using System;
using System.Collections.Generic;
using System.Linq;
using BusinessEntities;
using Common;
using Core.Factories;
using Data.Repositories;

namespace Core.Services.Products
{
    [AutoRegister]
    public class CreateProductService : ICreateProductService
    {
        public ProductDto Create(string name, string description, decimal price)
        {
            ProductDto newOne = new ProductDto();
            var productionId = ProductStore.productList.Max(prod => prod.Id) + 1;
            var newProd = new ProductDto { Id = productionId, Name = name, Description = description, Price = price };
            ProductStore.productList.Add(newProd);
            return newProd;
        }
    }
}