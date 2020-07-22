using System;
using System.Data.SqlClient;

namespace DataAccess.SqlClient
{
    public class SqlClientExploration
    {
        public static string _connectionString = "Data Source=localhost,1433;Initial Catalog=MusicStore;User ID=SA;Password=szkolenie_483";

        public static void ReadData()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from MusicTrack", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var artist = reader["Artist"].ToString();
                    var title = reader["Title"].ToString();

                    Console.WriteLine($"Artist: {artist}, title: {title}");
                }
            }
        }
    }
}