using System;
using System.Runtime.CompilerServices;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface ILogging
    {
        void Log();
    }

    class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    interface ICaching
    {
        void Cache();
    }

    class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User Checked");
        }
    }

    interface IAuthorize
    {
        void CheckUser();
    }

    // Facade diyoruki bu yapıyı böyle kurmak yerine aşağıdaki class gibi kur diyor. Cross cutting concerns kullan diyor
    class CustomerManager
    {
        CrossCuttingCorcernsFacade _concerns;
        public CustomerManager()
        {
            _concerns = new CrossCuttingCorcernsFacade();
        }
        public void Save()
        {
            _concerns.Logging.Log();
            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();
            Console.WriteLine("Saved");
        }
    }

    class CrossCuttingCorcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;

        public CrossCuttingCorcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }
}
