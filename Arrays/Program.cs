using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Utku";
            students[1] = "Umut";
            students[2] = "Nuray";

            string[] students2 = new string[]
            {
                "Utku",
                "Umut",
                "Nuray"
            };

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
    }
}
