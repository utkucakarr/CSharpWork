using NorthWind.Entities.Concrete;
using System.Collections.Generic;

namespace NorthWind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetProductsByCategory(int categoryId);

        List<Product> GetProductByProductName(string search);

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
