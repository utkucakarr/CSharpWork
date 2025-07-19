using NorthWind.Entities.Concrete;

namespace NorthWind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
