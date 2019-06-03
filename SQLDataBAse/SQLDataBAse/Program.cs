using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLDataBAse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C-Advance-2019-04-23\SQLDataBAse\SQLDataBAse\KCS.mdf;Integrated Security=True";
            string querry = "INSERT INTO students(Name, Surname) VALUES( @Name, @Surname)";
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(querry, sql))
                {
                    command.Parameters.AddWithValue(@"Name", "Petras");
                    command.Parameters.AddWithValue(@"Surname", "Petraitis");
                    sql.Open();
                    int rezult = command.ExecuteNonQuery();
                }
            }
        }
    }
}