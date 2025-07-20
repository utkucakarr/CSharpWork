using FactoryMethod.Concerete;
using System;

namespace FactoryMethod
{
    public class PizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            switch (type.ToLower())
            {
                case "margheritta":
                    return new Margherita();
                case "pepperoni":
                    return new Pepperoni();
                default:
                    throw new ArgumentException("Geçersiz pizza türü");
            }
        }
    }
}
