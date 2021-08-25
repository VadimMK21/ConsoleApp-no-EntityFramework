using System;
using Microsoft.Data.Sqlite;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=UsersDB.sqlite";
            var connection = new SqliteConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM users";

            SqliteCommand command = new SqliteCommand(query, connection);

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //dataGridView1.DataSource
                string id = reader.GetString(0);
                string name = reader.GetString(1);
                 
                Console.WriteLine($"Id: {id}, Name: {name}");
            }
        }
    }
}