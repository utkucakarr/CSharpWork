using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NorthWind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product{
                    ProductID = 1,
                    CategoryID = 1,
                    ProductName = "Laptop",
                    QuantityPerUnit = "1 in a box",
                    UnitPrice = 3000,
                    UnitsInStock = 11}
            };
            return products;
        }

        public Product GetProduct(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
