using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.MessageSenderBase = new MailSender();
            customerManager.UpdateCustomer();
            Console.ReadLine();
        }
    }

    abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Saved!");
        }

        public abstract void Send(Body body);
    }

    class Body
    {
        public string Title { get; set; }

        public string Text { get; set; }
    }

    class MailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was send via MailSender", body.Title);
        }
    }

    class SmsSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was send via SmsSender", body.Title);
        }
    }

    // Değişkenlik gösterecek classımız

    class CustomerManager
    {
        public MessageSenderBase MessageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new Body { Title = "About the Course!"});
            Console.WriteLine("Customer updated");
        }
    }
}
