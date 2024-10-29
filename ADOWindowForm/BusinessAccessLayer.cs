using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOWindowForm
{
    public class BusinessAccessLayer
    {

        public static List<Department> GetDepartments()
        {
            DataTable dataTable = DataAccessLayer.getDepartment();

            List<Department> departments = new List<Department>();

            foreach (DataRow dr in dataTable.Rows)
            {
                departments.Add(new Department()
                {
                    DepartmentId = (int)dr["department_id"],
                    DepartmentName = dr["department_name"].ToString()
                });
            }
            return departments;
        }

        public static void AddEmployee(int SSN ,string FirstName ,string LastName ,string Address ,int DepartmentNumber ,double Salary ,DateTime BirthDate)
        {
            string Querey = $"insert into Employee (ssn, first_name , last_name , employee_address ,birth_date , department_id , salary) values({SSN},'{FirstName}','{LastName}','{Address}','{BirthDate}',{DepartmentNumber},{Salary})";

            DataAccessLayer.AddEmployee(Querey);
        }

        public static void UpdateEmployee(int SSN, string FirstName, string LastName, string Address, int DepartmentNumber, double Salary, DateTime BirthDate)
        {
            string Querey = $"update Employee set first_name ='{FirstName}', last_name = '{LastName}',employee_address = '{Address}',birth_date = '{BirthDate}' ,department_id = {DepartmentNumber},salary = {Salary} Where ssn =={SSN}";

            DataAccessLayer.UpdateEmployee(Querey);
        }

        public static void DeleteEmployee(int SSN)
        {
            string Querey = $"Delete From Employee where ssn = {SSN}";

            DataAccessLayer.DeleteEmployee(Querey);
        }
    }
}
