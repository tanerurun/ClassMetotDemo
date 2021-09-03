using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.email = "taner.urun@outlook.com";
            customer.name = "taner";
            customer.id = 1;
            customer.phoneNumber="1234567890";
            customer.lastName = "ürün";

            CustomerManager customerManager= new CustomerManager();
            customerManager.add(customer);





            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
