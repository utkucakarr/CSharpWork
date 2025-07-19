using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfacesIntro();

            Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(), 
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager manager = new CustomerManager();
            manager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Utku",
                LastName = "Çakar",
                Address = "Sakarya"
            };
            personManager.Add(customer);

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Umut",
                LastName = "Çakar",
                Department = "Computer Sciences"
            };
            personManager.Add(student);

            Worker worker = new Worker()
            {
                Id = 1,
                FirstName = "Umut",
                LastName = "Çakar",
                Address = "İstanbuk"
            };
            personManager.Add(worker);
        }
    }

    interface IPerson
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
