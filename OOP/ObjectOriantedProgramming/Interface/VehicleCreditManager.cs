using System;

namespace Interface
{
    internal class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new System.NotImplementedException();
        }
    }
}
