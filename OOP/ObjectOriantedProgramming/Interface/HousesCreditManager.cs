using System;

namespace Interface
{
    internal class HousesCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new System.NotImplementedException();
        }
    }
}
