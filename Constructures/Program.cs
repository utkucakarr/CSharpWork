using System;

namespace Constructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.List();

            Product product = new Product()
            {
                Id = 1,
                Name = "Laptop"
            };
            Product product2 = new Product(2, "Klavye");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;

            Utilities.Validation();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {
            
        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FilerLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class EmployeeManager
    {
        private readonly ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entitiy;

        public BaseClass(string entitiy)
        {
            _entitiy = entitiy;
        }

        public void Message()
        {
            Console.WriteLine("{0} meesage", _entitiy);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entitiy) : base(entitiy)
        {
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        public static void Validation()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
