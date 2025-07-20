using System;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Factory design patter eğer hangi sınıf örneği ile çalışacağımıza çalışma anında karar veriyorsak o zaman kullanırız.
            PizzaFactory pizzaFactory = new PizzaFactory();

            Console.WriteLine("Pizza türünü gitiniz (margheritta / pepperoni): ");
            string input = Console.ReadLine();

            IPizza pizza = pizzaFactory.CreatePizza(input);
            pizza.Prepare();
        }
    }
}