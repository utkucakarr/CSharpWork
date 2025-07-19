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
        // Dışarıdan ulaşılamaz bir nesne haline getirdik.
        private CustomerManager() 
        {
            
        }

        public static CustomerManager CreateAsSingleton()
        {
            if (_customerManager == null)
            {
                _customerManager = new CustomerManager();
            }
            return _customerManager;
        }
    }
}
