using System;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Utku", LastName = "Çakar", Age = 26 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }

    class CustomerDal
    {
        // Obselete hazır bir attribute'dur. Bu attribute kullanan kişi bir uyarı alır. Eski olduğunu belirtir.
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    // Kendimiz bir attribute oluşturduk
    // Burada pipe(|) ile 2 tane alan verebiliyoruz field ve nesne için çalışacak diyoruz. 
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]

    //AllowMultiples ise bu attribute'u birden fazla kere uygulayabilir miyim demek.
    //[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]

    //Buda AttributeTargets sadece nesneler için geçerli demek
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    // Required property sadece classların üzerine eklenebilir demek
    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

    class MyClass
    {
        
    }
}