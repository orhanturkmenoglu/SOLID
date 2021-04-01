using System;
using System.Collections.Generic;
using System.Text;

namespace Open___Closed_Principle
{
    class HataliKullanim
    {
        static void Main(string[] args)
        {
            // Hatali Kullanim 
            // Nedeni ileride gelecek olan gereksinimler artacagı için koda müdahale edilmesi gereklidir ayrıca kod tekrarı önlenmelidir.
            // Open /Closed prensibi yazılımlar değişime kapalı sadece gelişime açık olmalıdır Kural ihlali vardır.   
        }



        public class Mysql
        {
            public void Log()
            {
                Console.WriteLine("MySql Loglandı..");
            }
        }

        public class SqlServer
        {
            public void Log()
            {
                Console.WriteLine("Sql Server Loglandı..");
            }
        }


        public class DatabaseManager
        {
            // Hatali kullanım 
            public void Log(SqlServer sqlServer)
            {
                sqlServer.Log();
            }

            // Yeni gelen gereksinimle koda müdahale edilecektir.
            //public void Log(Mysql mysql)
            //{
            //    mysql.Log();
            //}
        }
    }
}
