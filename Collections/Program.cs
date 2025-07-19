using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList();

            List();

            Dictionary();

            Console.ReadLine();
        }

        private static void Dictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");

            Console.WriteLine(dictionary["Table"]);
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            bool isWithin = dictionary.ContainsKey("Table");
            Console.WriteLine(isWithin);
        }

        private static void List()
        {
            //Güvenli collection veri tipi
            List<string> cities = new List<string>();
            cities.Add("Adana");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Adana"));
            Console.WriteLine(cities.Contains("Sakarya"));
            Console.WriteLine("***************");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("***************");
            List<Customer> customers = new List<Customer>
            {
                new Customer(){Id = 1, FirstName = "Utku"},
                new Customer(){Id = 2, FirstName = "Umut"}
            };
            //Collection methodları
            var customerCount = customers.Count();
            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Nuray"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 5, FirstName = "Ahmet"},
                new Customer{Id = 6, FirstName = "Mehmet"}
            });
            customerCount = customers.Count();
            //customers.Clear();
            Console.WriteLine(customers.Contains(customer1));
            Console.WriteLine("***************");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.WriteLine("***************");
            Console.WriteLine("Count : {0}", customerCount);
            Console.WriteLine("***************");

            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index : {0}", index);
            Console.WriteLine("***************");

            customers.Add(customer1);
            var index2 = customers.LastIndexOf(customer1);
            Console.WriteLine("Index : {0}", index2);
            Console.WriteLine("***************");

            //Belirtilen indexe yeni bir değer eklemek için
            customers.Insert(1, customer1);
            Console.WriteLine(customers[1].FirstName);

            customers.Remove(customer1);

            var count2 = customers.Count();
            Console.WriteLine(count2);
        }

        private static void ArrayList()
        {
            string[] cities = new string[2]
            {
                "Ankara",
                "İstanbul"
            };
            cities = new string[3];
            Console.WriteLine(cities[0]);
            //Hangi tip veriler ile çalışıcağımız belli değil ise arrayListler ile çalışırız.
            ArrayList cities1 = new ArrayList();
            cities1.Add("Ankara");
            cities1.Add("İstanbul");
            cities1.Add('A');
            cities1.Add(1);

            foreach (var city in cities1)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
    }
}
