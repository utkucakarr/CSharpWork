using System;
using System.Collections.Generic;
using System.Threading;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExeptionIntro();

            // TryCatch();

            //Method
            //Burada () işaret methodu temsil ediyor. Ve Methodumda Find() diyoruz.
            // ActionDemo();

            // Buradaki 1. int x, 2. int y, 3.int result'a karşılık geliyor.
            Func<int, int, int> add = Sum;
            Console.WriteLine(add(3, 4));

            Console.WriteLine(Sum(2, 3));

            //Parametresiz methodlara delete yapıyor
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            //Farklı yazım şekli
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Thread.Sleep(5000);
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleExeption(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleExeption(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> Students = new List<string>()
            {
                "Utku",
                "Umut",
                "Nuray"
            };

            if (!Students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExeptionIntro()
        {
            try
            {
                string[] students = new string[3]
                {
                    "Utku",
                    "Umut",
                    "Nuray"
                };
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}