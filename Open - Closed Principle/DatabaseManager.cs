namespace Open___Closed_Principle
{
    partial class Program
    {
        public class DatabaseManager 
        {
            
            private IDatabaseService _databaseService;
            public DatabaseManager(IDatabaseService databaseService)
            {
                _databaseService = databaseService;
            }
            public void Log()
            {
                _databaseService.Log();
            }
        }


    }

}
