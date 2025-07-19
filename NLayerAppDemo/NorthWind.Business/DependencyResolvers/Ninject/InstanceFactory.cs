using Ninject;
using Ninject.Modules;

namespace NorthWind.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>() // Metodun generic yapılması deniyor bu işelem
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
