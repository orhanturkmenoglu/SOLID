using System;

namespace Dependency_Inversion_Principle
{
    partial class Program
    {
        public class RealCustomer : ICustomer
        {
            public void Add()
            {
                Console.WriteLine("Gerçek Müşteri Eklendi");
            }
        }
    }
}
