using System;
using NorthWind.Business.Abstract;
using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;
using System.Collections.Generic;
using NorthWind.Business.ValidationRules.FluentValidation;
using NorthWind.Business.Utilities;

namespace NorthWind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        //Dependency Injection
        private readonly IProductDal _productDal;

        // Product Manager newlendiğinde bana bir IProductDal türünde bir nesne ver
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemdi");
            }
        }

        public List<Product> GetAll() 
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductByProductName(string search)
        {
            return _productDal.GetAll(x => x.ProductName.ToLower().Contains(search.ToLower()));
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(x => x.CategoryID == categoryId);
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}
