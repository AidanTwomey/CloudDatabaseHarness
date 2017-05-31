using System;
using System.Data.SqlClient;

namespace HelloCloudSql
{
    class Program
    {
        const string sql_connection = "Server=tcp:aidan-mssql.c9i3yi2murx6.eu-west-1.rds.amazonaws.com,1433;Initial Catalog=musicDownloads;User Id=aidan2mey;Password=lalaland;";
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(sql_connection))
            {
                var command = new SqlCommand("select * from product", connection);
                connection.Open();
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]}:{reader[1]}");
                    }
                }
            }
        }
    }
}
