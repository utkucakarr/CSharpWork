using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //ForLoop2();
            //ForLoop3();
            //ForLoop4();

            //WhileLoop();

            //DoWhileLoop();

            //ForeachLoop();

            if (IsPrimeNumber(3))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

        }

        private static bool IsPrimeNumber(int number)
        {
            int sayac = 0;
            for (int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ForeachLoop()
        {
            string[] students = new string[3];
            students[0] = "Utku";
            students[1] = "Umut";
            students[2] = "Nuray";
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 0;
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number < 100);
            Console.ReadLine();
        }

        private static void WhileLoop()
        {
            int number = 0;
            while (number <= 100)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        private static void ForLoop4()
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }

        private static void ForLoop3()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Finished");
        }

        private static void ForLoop2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }
    }
}
