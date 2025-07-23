using System;

namespace Interface
{
    // İhtiyaç kredisi
    internal class DemandCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new System.NotImplementedException();
        }
    }
}
