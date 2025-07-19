using System;
using System.Data;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value type reference
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            //Reference type Array, string, class, delegeted

            string[] cities1 = new string[]
            {
                "Ankara",
                "Adana",
                "Afyon"
            };
            string[] cities2 = new string[]
            {
                "Bursa",
                "Bolu",
                "Balıkesir"
            };
            //cities2'nin referansı eşittir cities1'in referansı
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }
    }
}
