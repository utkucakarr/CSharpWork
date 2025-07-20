using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Utku",
                LastName = "Çakar",
                City = "İstanbul"
            };

            var customer2 = (Customer)customer.Clone();
            customer2.FirstName = "Umut";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    public abstract class Person
    {
        public abstract Person Clone();

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class Customer : Person
    {
        public string City { get; set; }

        // Elimizdeki customer'ı clonelamamızı sağlar
        public override Person Clone()
        {
            return (Person) MemberwiseClone();
        }
    }

    public class Employee : Person
    {
        public decimal Salary { get; set; }

        // Elimizdeki customer'ı clonelamamızı sağlar
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
