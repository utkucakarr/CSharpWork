using System;
using System.Collections.Generic;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            //Burada hangi tipte data verirsek verelim onu o tipte bir liste haline getirir.
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> customers = utilities.BuildList<Customer>(new Customer { FirstName = "Utku"}, new Customer { FirstName = "Umut"});
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Utilities 
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product : IEntity
    {

    }

    interface IProductDal : IRepository<Product>
    {

    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }
    // Sen bir IRepository'sin ve çalışma tipin Customer demek
    interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
    }

    //Generic kısıtlamalar sadece sınıf yazmasını istiyoruz
    interface IStudentDal : IRepository<Student>
    {
        
    }

    class Student : IEntity
    {
        
    }

    interface IEntity
    {

    }

    //Generikler ile sıklıkla yaptığımız operasyonları nesne bazlı olarak değiştirebileceğimiz ben bu nesneyle çalışıcağım diyebiliyoruz yapıya işaret eder.
    //Generic class kısıtlaması ile T yerine bir referans tip yazmasını istiyoruz.
    //, new() demek bu referans tipin new'lenebilir olması koşulunuda ekler.
    // Sadece veri tabanı nesneleri yazılabilsin istediğimizde. IEntitiy'den imlemente edilmeli diyoruz.


    //interface IRepository<T> where T : struct Sadece değer tip vermek istediğimizde Struct yazılır.
    interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();

        T Get(int id);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }

    class ProductDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public void Custom()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new System.NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public void Custom()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
