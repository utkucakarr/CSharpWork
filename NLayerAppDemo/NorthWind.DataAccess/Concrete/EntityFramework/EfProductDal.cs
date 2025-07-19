using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;
namespace NorthWind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthWindContext>, IProductDal
    {
    }
}
