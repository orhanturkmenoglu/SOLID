using System;

namespace Dependency_Inversion_Principle
{
    partial class Program
    {
        public class LegalCustomer : ICustomer
        {
            public void Add()
            {
                Console.WriteLine("Tüzel Müşteri Eklendi");
            }
        }
    }
}
