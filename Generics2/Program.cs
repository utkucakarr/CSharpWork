using System;

namespace Generics2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Generics ile kendi list'imizi oluşturma

            MyList<string> myList = new MyList<string>();
            myList.Add("a");
            myList.Add("b");
            myList.Add("c");

            foreach (var list in myList.Items)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine(myList.Length);
            Console.ReadLine();
        }
    }
}
