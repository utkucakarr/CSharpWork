using System;

namespace FactoryMethod.Concerete
{
    public class Pepperoni : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Pepperoni Pizza hazırlanıyor.");
        }
    }
}
