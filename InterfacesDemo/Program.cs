using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eat = new IEat[2] 
            {
                new Manager(),
                new Worker()
            };

            foreach (var item in eat)
            {
                item.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Get salary");
        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }

    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Get Salary");
        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
}