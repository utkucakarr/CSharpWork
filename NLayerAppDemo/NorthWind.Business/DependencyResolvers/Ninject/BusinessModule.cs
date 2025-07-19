using Ninject.Modules;
using NorthWind.Business.Abstract;
using NorthWind.Business.Concrete;
using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Concrete.EntityFramework;

namespace NorthWind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            // Biri senden IProductService ister ise somut bir ProductManager sınıfı döndür.
            Bind<IProductService>().To<ProductManager>().InSingletonScope(); // InSingletonScope bir kere üretildiğinde bir daha üretilmesin amacıyla kullanılır.
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>();
            
        }
    }
}
