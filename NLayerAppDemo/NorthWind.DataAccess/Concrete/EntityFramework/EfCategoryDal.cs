using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;

namespace NorthWind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthWindContext>, ICategoryDal
    {
    }
}
