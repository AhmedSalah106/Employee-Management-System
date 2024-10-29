using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOWindowForm
{
    public class DataAccessLayer
    {
        static SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-7F64LMS;Initial Catalog=Company;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        static SqlCommand sqlCommand = new SqlCommand();
       

        public static DataTable getDepartment()
        {
            sqlCommand.CommandText = "select * from Departments";

            sqlCommand.Connection = sqlConnection;

            DataTable dataTable = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

            dataAdapter.Fill(dataTable);

            return dataTable; 
        }
        public static void AddEmployee(string Querey)
        {
            sqlCommand.CommandText = Querey;

            sqlConnection.Open();  

            sqlCommand.ExecuteNonQuery();
        }

        public static void UpdateEmployee(string Querey)
        {
            sqlCommand.CommandText = Querey;

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

        }

        public static void DeleteEmployee(string Querey)
        {
            sqlCommand.CommandText = Querey;

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();
        }
    }
}
