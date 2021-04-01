using System;

namespace Open___Closed_Principle
{
    partial class Program
    {
        public class Oracle : IDatabaseService
        {
            public void Log()
            {
                Console.WriteLine("Oracle Loglandı");
            }
        }


    }

}
