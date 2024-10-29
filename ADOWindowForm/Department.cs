using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOWindowForm
{
    public class Department
    {
        public int DepartmentId {  get; set; }
        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return $"{DepartmentName}";
        }
    }
}
