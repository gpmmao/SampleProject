using System.Collections.Generic;
using BusinessEntities;
using Data.Repositories;

namespace Core.Services.Products
{
    public interface IUpdateProductService
    {
        void Update(int  productId, string name, string description, decimal price);
    }
}