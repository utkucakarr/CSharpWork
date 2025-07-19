using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine(Add2(/*3, 4*/));
            int number1 = 20;
            int number2 = 40;
            int number3 = 5;
            int number4 = 4;
            int number5 = 2;
            var result = Add3(ref number1, out number2);
            var result2 = Multiply(number3, number4, number5);
            var result3 = Add4(3, 4, 5, 6, 7);
            Console.WriteLine(result);
            Console.WriteLine(number2);
            Console.WriteLine(number2);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, out int number2)
        {
            number1 = 40;
            number2 = 30;
            return number1 + number2;
        }

        static int Multiply(int number3, int number4, int number5)
        {
            return number3 * number4 * number5;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
