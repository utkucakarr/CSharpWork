using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee utku = new Employee { Name = "Utku Çakar"};
            Employee umut = new Employee { Name = "Umut Çakar"};

            utku.AddSubordinate(umut);

            Employee nuray = new Employee { Name = "Nuray Çakar" };
            utku.AddSubordinate(nuray);

            Employee ahmet = new Employee { Name = "Ahmet Çakar" };
            umut.AddSubordinate(ahmet);

            Contractor contractor = new Contractor { Name = "Mehmet"};
            nuray.AddSubordinate(contractor);

            Console.WriteLine(utku.Name);
            foreach (Employee manager in utku)
            {
                Console.WriteLine("  {0}",manager.Name);
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("    {0}", employee.Name);
                }
            }
            Console.ReadLine();
        }
    }

    interface IPerson
    {
        string Name { get; }
    }

    class Contractor : IPerson
    {
        public string Name { get; set; }
    }

    // Enumarable içinde gezebilmemiz için kullanılıyor.
    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinates in _subordinates)
            {
                yield return subordinates;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
