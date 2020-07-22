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

        public static void UpdateData()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Update MusicTrack SET Artist ='Random Artist' where Id = 1", connection);

                int result = command.ExecuteNonQuery();
                Console.WriteLine($"Number of entries updated: {result}");
            }
        }

        //Test';Delete from MuiscTrack; --
        public static void SqlInjectionExample()
        {
            Console.WriteLine("Enter the title of track to update: ");
            var title = Console.ReadLine();
            Console.WriteLine("Enter new artist name: ");
            var newArtist = Console.ReadLine();
            var sqlCommandText = $"Update MusicTrack SET Artist ='{newArtist}' where Title='{title}'";
            Update(sqlCommandText);
        }

        public static void ProtectSqlInjectionExample()
        {
            Console.WriteLine("Enter the title of track to update: ");
            var title = Console.ReadLine();
            Console.WriteLine("Enter new artist name: ");
            var newArtist = Console.ReadLine();
            var sqlCommandText = $"Update MusicTrack SET Artist =@artist where Title=@title";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommandText, connection);
                command.Parameters.AddWithValue("@artist", newArtist);
                command.Parameters.AddWithValue("@title", title);
                command.ExecuteNonQuery();
            }
        }

        private static void Update(string sqlCommandText)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommandText, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}