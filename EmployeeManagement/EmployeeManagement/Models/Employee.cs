using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int empid { get; set; }
        public string empName { get; set; }
        public decimal empSalary { get; set; }
        public int deptId { get; set; }
    }
}