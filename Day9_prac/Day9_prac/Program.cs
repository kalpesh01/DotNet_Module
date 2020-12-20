using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_prac
{
    class Program
    {
        static void Main1(string[] args)
        {
        }
    }

    public class Department
    {
        
    }
    public class Employee
    {

    }
}

namespace LinqQuery
{
    class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();

        static void Main(string[] args)
        {
            AddRec();
            // var emps = from emp in lstEmp select emp;
            // IEnumerable<Employee> emps = from emp in lstEmp select emp;
            //  List<Employee> emps =(List<Employee>) from emp in lstEmp select emp;

            //var emps = from emp in lstEmp select emp.Name;

            //var emps = from emp in lstEmp
            //           where emp.Basic > 10000 && emp.Basic < 12000
            //           select emp;

            /*var emps = from emp in lstEmp
                       where emp.Name.StartsWith("a")
                       select emp;*/


            //var emps = from emp in lstEmp
            //           orderby  emp.Name descending
            //           select emp;


            //var emps = lstEmp.Select(GetEmployees);



            //passsing anonymous method as a paramete
            //var emps = lstEmp.Select(delegate (Employee obj)
            //  {
            //      return obj;
            //  });

            //using a lambda function
            //var emps = lstEmp.Select(emp => emp);

            var emps1 = lstEmp.Where(emp => emp.Basic > 11000);
            var emps2 = lstEmp.Where(emp=>emp.Basic >11000).Select(emp=>emp);
            var emps3 = lstEmp.Where(emp => emp.Basic > 11000).Select(emp => emp.Name);
            var emps = lstEmp.Where(emp => emp.Basic > 11000).Select(emp =>new { emp.Name,emp.Basic });

            var emps4 = lstEmp.Select(emp => emp).Where(emp => emp.Basic > 11000);
            var emps4b = lstEmp.Where(emp => emp.Basic > 11000).Select(emp => emp);


            var emps5 = lstEmp.Where(emp => emp.Basic > 11000).Select(emp => emp);  // returns INumerable<strings>
            var emps5b = lstEmp.Where(emp => emp.Basic > 11000)/* this part will return INumerable<string>*/.Select(emp => emp); //if we give
                                                                                                                                 //INumerable<string> to the next it can not fetch specific cokumn from object                    
              
            var emps6 = lstEmp.OrderBy(emp => emp.Name).Where(emp => emp.Basic >1000 ) ;

            var emps7 = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo,(emp,dept)=>emp);
            var emps8 = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp.Basic);
            var emps9 = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => dept.DeptName);
            var emps10 = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) =>new { emp.Basic ,dept.DeptName);


            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name);
            }
            Console.ReadLine();
        }

        static Employee GetEmployees(Employee obj)
        {
            return obj;
        }
        public static void AddRec()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "ss" });
            lstDept.Add(new Department { DeptNo = 11, DeptName = "aa" });
            lstDept.Add(new Department { DeptNo = 12, DeptName = "ff" });
            lstDept.Add(new Department { DeptNo = 13, DeptName = "yy" });

            lstEmp.Add(new Employee { EmpNo = 11, Name = "asd", Gender = 'm', DeptNo = 10, Basic = 1234 });
            lstEmp.Add(new Employee { EmpNo = 11, Name = "jhdd", Gender = 'm', DeptNo = 11, Basic = 1234 });
            lstEmp.Add(new Employee { EmpNo = 11, Name = "hyu", Gender = 'm', DeptNo = 12, Basic = 1234 });
            lstEmp.Add(new Employee { EmpNo = 11, Name = "ttt", Gender = 'm', DeptNo = 13, Basic = 1234 });
        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public int DeptNo { get; set; }
        public decimal Basic { get; set; }
    }
}
