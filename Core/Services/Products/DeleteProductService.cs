using BusinessEntities;
using Common;
using Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services.Products
{
    [AutoRegister]
    public class DeleteProductService : IDeleteProductService
    {
       
        public DeleteProductService()
        {
           
        }

        public void Delete(int prodId)
        {
            var prod = ProductStore.productList.FirstOrDefault(p => p.Id == prodId);
            if ( prod != null )
                ProductStore.productList.Remove(prod);
        }

        public void DeleteAll()
        {
            // set producList to new empty lis
            ProductStore.productList = new List<ProductDto>();
        }
    }
}