using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();

            string sentence = "My name is Utku Çakar";

            var result = sentence.Length; //lenght bir özelliktir.
            var result2 = sentence.Clone(); // clone bir method'dur.
            sentence = "My name is Umut Çakar";

            bool result3 = sentence.EndsWith("r");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("a");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf("a");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3, 4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace("a", "e");
            var result13 = sentence.Remove(3, 5);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            //Stringler aslında birer char arriyidir.
            string city = "İstanbul";
            //Console.WriteLine(city[2]);

            foreach (var ct in city)
            {
                Console.WriteLine(ct);
            }

            string city2 = "Ankara";
            string result = city + " " + city2;

            Console.WriteLine(result);
            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
