using NorthWind.Business.Abstract;
using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;
using System.Collections.Generic;

namespace NorthWind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
