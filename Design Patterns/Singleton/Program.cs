using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class CustomerManager
    {
        // Bu bir Field'dır
        private static CustomerManager _customerManager;
        static object _lockObject = new object();
        // Dışarıdan ulaşılamaz bir nesne haline getirdik.
        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSingleton()
        {
            // Nesne üretme esnasında eğer bir üretim varsa işlemi kitlemek için lock kullanılır.
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;
        }

        public void Save()
        {
            Console.WriteLine("Save");
        }
    }
}
