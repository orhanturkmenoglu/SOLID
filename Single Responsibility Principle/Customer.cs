using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility_Principle
{
    // Single responsibility : aykırılık vardır çunku bir classın sadece bir sorumlulugu olmalıdır 
    // fakat bu örnekte bir class hem nesneye ait özellik tanımlanmış ve bu nesneye ait yine operasyonlar tanımlanmıştır
    // hatalı kullanım. tek sorumluluk sahibi olmalıdır.
   public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Hatalı Kullanım.

        //public void Add(Customer customer)
        //{
        //    Console.WriteLine("Customer added"+customer.FirstName);
        //}

        //public void Delete(Customer customer)
        //{
        //    Console.WriteLine("Customer deleted" + customer.FirstName);
        //}


        //public void Update(Customer customer)
        //{
        //    Console.WriteLine("Customer updated" + customer.FirstName);
        //}

    }
}
