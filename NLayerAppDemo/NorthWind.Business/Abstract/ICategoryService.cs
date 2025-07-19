using NorthWind.Entities.Concrete;
using System.Collections.Generic;

namespace NorthWind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
