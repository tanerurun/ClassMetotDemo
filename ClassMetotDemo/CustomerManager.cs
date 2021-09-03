using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager : ICustomerService
    {
        public void add(Customer customer)
        {
            Console.WriteLine("MÜŞTERİ EKLENDİ");
        }

        public void delete(Customer customer)
        {
            Console.WriteLine("MÜŞTERİ KAYDI SİLİNDİ");
        }

        public void update(Customer customer)
        {
            Console.WriteLine("MÜŞTERİ GÜNCELLENDİ");
        }
    }
}
