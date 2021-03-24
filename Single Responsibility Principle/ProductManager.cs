using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility_Principle
{
   public class ProductManager
    {
        // Doğru kullanımı bu olmalıdır. 
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added" + customer.FirstName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted" + customer.FirstName);
        }


        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated" + customer.FirstName);
        }
    }
}
