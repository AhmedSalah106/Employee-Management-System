using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-7F64LMS;Initial Catalog=DB_test;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

            SqlCommand sqlCommand = new SqlCommand();
            
            sqlCommand.Connection = sqlConnection;

            sqlCommand.CommandText = "select * from Students;";

            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while(reader.Read())
            {
                int id = (int)reader[0];
                string name = (string)reader[1];
                Console.WriteLine($"{name} : {id}");
            }
           sqlConnection.Close();
        }
    }
}
