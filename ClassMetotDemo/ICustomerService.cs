using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    interface ICustomerService
    {
        public void add(Customer customer);
        public void update(Customer customer);
        public void delete(Customer customer);
    }
}
