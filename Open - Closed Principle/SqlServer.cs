using System;

namespace Open___Closed_Principle
{
    partial class Program
    {
        public class SqlServer : IDatabaseService
        {
            public void Log()
            {
                Console.WriteLine("Sql Server Loglandı");
            }
        }


    }

}
