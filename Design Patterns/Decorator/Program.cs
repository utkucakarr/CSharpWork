using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personelCar = new PersonelCar { Brand = "BMW", Model = "4.20", HirePrice = 2500 };

            SpecialOffer specialOffer = new SpecialOffer(personelCar);
            specialOffer.DiscountPercentage = 10;

            Console.WriteLine("Concrete : {0}", personelCar.HirePrice);
            Console.WriteLine("Special offer : {0}", specialOffer.HirePrice);

            Console.ReadLine();
        }
    }

    abstract class CarBase
    {
        // Bunları ezmek istediğimiz için abstract yaptık.
        public abstract string Brand { get; set; }

        public abstract string Model { get; set; }

        public abstract decimal HirePrice { get; set; }
    }

    class PersonelCar : CarBase
    {
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    class CommercialCar : CarBase
    {
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    abstract class CarDecoretorBase : CarBase
    {
        private CarBase _carBase;

        protected CarDecoretorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }

    class SpecialOffer : CarDecoretorBase
    {
        public int DiscountPercentage { get; set; }

        private readonly CarBase _carBase;

        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public override string Brand { get; set; }

        public override string Model { get; set; }

        public override decimal HirePrice
        {
            get
            {
                return _carBase.HirePrice - _carBase.HirePrice * DiscountPercentage / 100;
            }
            set
            {
            }
        }
    }
}
