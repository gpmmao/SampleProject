using System;
using System.Collections.Generic;
using BusinessEntities;
using Data.Repositories;

namespace Core.Services.Products
{
    public interface ICreateProductService
    {
        ProductDto Create(string name, string description,decimal price);
    }
}