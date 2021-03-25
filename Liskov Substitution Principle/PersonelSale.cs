using System;

namespace Liskov_Substitution_Principle
{
    public class PersonelSale : IPersonelSale,ICustomerLookAt
    {
        public void CustomerLookAt()
        {
            Console.WriteLine("Müşteri ile ilgilen.");
        }

        public void Sell()
        {
            Console.WriteLine("Satış yap.");
        }
    }




}
