using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.CreditCalculatorBase = new After2025CreditCalculator();
            customerManager.SaveCredit();

            customerManager.CreditCalculatorBase = new Before2025CreditCalculator();
            customerManager.SaveCredit();
            Console.ReadLine();
        }
    }
    abstract class CreditCalculatorBase
    {
        public abstract void Calculate();
    }

    class Before2025CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated usign before 2025");
        }
    }

    class After2025CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated usign after 2025");
        }
    }

    class CustomerManager
    {
        public CreditCalculatorBase CreditCalculatorBase { get; set; }

        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business");
            CreditCalculatorBase.Calculate();
        }
    }
}
