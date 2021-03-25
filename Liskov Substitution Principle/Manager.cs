using System;

namespace Liskov_Substitution_Principle
{
    
    public class Manager : IManager
    {
        public void Manage()
        {
            Console.WriteLine("Yönet.");
        }
    }




}
