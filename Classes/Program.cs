using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class'ın bir referansını oluşturuyoruz.
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            Customer customer = new Customer();

            customerManager.Add();
            customerManager.Update();
            productManager.Add();
            productManager.Update();
            customer.Id = 1;
            customer.FirstName = "Utku";
            customer.LastName = "Çakar";
            customer.City = "Sakarya";

            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Umut",
                LastName = "Çakar",
                City = "İstanbul"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
