using System;

namespace Delegate
{
    // Bu bir elçi void döndüren methodlara ve parametre almayan methodlara delegelik yapıyor.
    public delegate void MyDelegate();
    // Parametre alan bir delege
    public delegate void MyDelegate2(string text);
    // int dönüşü yaıcak ve parametreli delege
    public delegate int MyDelegate3(int number1, int number2);

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            //Delege ile kullanmak istediğimizde
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Hello");

            Mathematics mathematics = new Mathematics();
            MyDelegate3 myDelegate3 = mathematics.Sum;
            myDelegate3 += mathematics.Multiply;
            var result = myDelegate3(3,4);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Mathematics
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
