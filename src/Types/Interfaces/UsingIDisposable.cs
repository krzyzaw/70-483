using System;

namespace Types.Interfaces
{
    public class UsingIDisposable
    {
        public class DatabaseConnection : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose callad");
            }

            public static void Test()
            {
                using (DatabaseConnection conn = new DatabaseConnection())
                {
                    // do something with the db connection
                }
            }
        }
    }
}