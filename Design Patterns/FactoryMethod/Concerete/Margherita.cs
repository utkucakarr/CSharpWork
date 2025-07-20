using System;

namespace FactoryMethod
{
    public class Margherita : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Margherita pizza hazırlanıyor.");
        }
    }
}
