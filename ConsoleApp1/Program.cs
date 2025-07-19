using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 200;
            if (number < 100)
            {
                if (number >= 90)
                {
                    Console.WriteLine("Bu sayı 90'dan büyük ve 100'den küçüktür");
                }
            }
            else
            {
                Console.WriteLine("Sayı 100'den büyüktür.");
            }
            Console.ReadLine();
        }
    }
}
