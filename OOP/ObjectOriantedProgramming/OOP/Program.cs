namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gerçek Müşteri
            IndividualCustomer customer = new IndividualCustomer();
            customer.Id = 1;
            customer.CustomerId = "12345";
            customer.Name = "Utku";
            customer.Surname = "Çakar";
            customer.IdNumber = "1234567890";

            // Tüzel Müşteri
            CorparateCustomer customer2 = new CorparateCustomer();
            customer2.CustomerId = "12345";
            customer2.CompanyName = "54321";
            customer2.CompanyName = "Apple";
            customer2.TaxNumber = "1234567890";

            // Müşteri class'ı hem gerçek müşterinin referansını tutabiliyor hemde tüzel müşterinin referansını tutabiliyor.
            Customer customer3 = new IndividualCustomer();
            Customer customer5 = new CorparateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer2);
        }
    }
}
