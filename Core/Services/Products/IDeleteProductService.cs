using BusinessEntities;
using Data.Repositories;

namespace Core.Services.Products
{
    public interface IDeleteProductService
    {
        void Delete( int prod);
        void DeleteAll();
    }
}