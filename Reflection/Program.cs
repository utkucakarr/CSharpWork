using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FourOperations fourOperations = new FourOperations(2, 3);
            //Console.WriteLine(fourOperations.Add(3, 4));
            //Console.WriteLine(fourOperations.Add1());

            //Reclection ile yapılmış hali
            //Burada benim çalışıcağım bir iş var oda FourOperations diyoruz
            var type = typeof(FourOperations);
            // Burada çalışma anında gelen tipe göre bir instance oluşturuyoruz.
            //FourOperations fourOperation = (FourOperations)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(fourOperation.Add(4, 5));
            //Console.WriteLine(fourOperation.Add1());

            var instance = (FourOperations)Activator.CreateInstance(type, 6, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Add1");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            //Methodlara ulaşma örneği
            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Method adı : {0}", info.Name);
                //Parametrelere ulaşma
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parameterInfo.Name);
                }
                //Attributelara ulaşma
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            } 

            Console.ReadLine();
        }
    }

    public class FourOperations
    {
        private int _number1;
        private int _number2;

        public FourOperations(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public FourOperations()
        {
            
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Add1()
        {
            return _number1 + _number2;
        }

        [MethodName("Carpma")]
        public int Multiply2()
        {
            return _number1 * _number2;
        }
    }
    public class MethodNameAttribute : Attribute
    {
        private string v;

        public MethodNameAttribute(string v)
        {
            this.v = v;
        }
    }
}