using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOWindowForm
{
    public partial class FormBirthDate : Form
    {
        public FormBirthDate()
        {
            InitializeComponent();

            comboBox1.ValueMember = "Id";

            comboBox1.DisplayMember = "Name";

            comboBox1.DataSource = BusinessAccessLayer.GetDepartments();

            ButtonAdd.Click += ButtonAdd_Click;

            ButtonUpdate.Click += ButtonUpdate_Click;

            ButtonDelete.Click += ButtonDelete_Click;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int SSN = Convert.ToInt32(SsnTxt.Text);

            BusinessAccessLayer.DeleteEmployee(SSN);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            int SSN = Convert.ToInt32(SsnTxt.Text);
            string FirstName = FirstNameTxt.Text;
            string LastName = LastNameTxt.Text;
            string Address = AddressTxt.Text;
            int DepartmentNumber = Convert.ToInt32(DeptNumTxt.Text);
            double Salary = Convert.ToDouble(SalaryTxt.Text);
            DateTime dateTime = BirthDatePicker.Value;

            BusinessAccessLayer.UpdateEmployee(SSN, FirstName, LastName, Address, DepartmentNumber, Salary, dateTime);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int SSN = Convert.ToInt32(SsnTxt.Text);
            string FirstName = FirstNameTxt.Text;
            string LastName = LastNameTxt.Text;
            string Address = AddressTxt.Text;
            int DepartmentNumber =Convert.ToInt32( DeptNumTxt.Text);
            double Salary = Convert.ToDouble( SalaryTxt.Text);
            DateTime dateTime = BirthDatePicker.Value;

            BusinessAccessLayer.AddEmployee(SSN,FirstName, LastName, Address, DepartmentNumber, Salary, dateTime);
        }

 
    }
}
