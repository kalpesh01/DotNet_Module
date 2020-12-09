using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<decimal, decimal, decimal, decimal> si = (p, r, t) => { return (p * r * t) / 100; };
            Console.WriteLine("Enter the Principal,rate and time to calculate SI....");
            decimal P = Convert.ToDecimal(Console.ReadLine());
            decimal R = Convert.ToDecimal(Console.ReadLine());
            decimal T = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(si(P, R, T));

            Console.WriteLine("************************************************************");

            Func<int, int, bool> isGreater = (a, b) => { return a > b; };
            Console.WriteLine("Enter the two numbers to compare which is greater");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(isGreater(A, B));

            Console.WriteLine("************************************************************");


            Console.WriteLine("Employee Basic Salary ........");
            Employee e = new Employee("Employee3",9000,5);
            Func<Employee, decimal> emp = (empobj) => { return empobj.Basic; };
            Console.WriteLine("Employee Basic : "+emp(e)); 
            Console.ReadLine();
     

            Predicate<int> isEven = (no) => { return no % 2 == 0; };
            Console.WriteLine("Enter the Number To Check Even Or Odd ");
            int no2 = Convert.ToInt32(Console.ReadLine());

            if(isEven(no2))
            {
                Console.WriteLine("No is Even ");
            }
            else
            {
                Console.WriteLine("No is odd ");
            }


            Console.WriteLine("To check Employee Basic Salary ........");
            Employee e2 = new Employee("Employee", 9000, 3);
            Predicate<Employee> emp2 = (empobj2) => { return empobj2.Basic > 10000; };
            if (emp2(e2))
            {
                Console.WriteLine("Employee Basic salary is greate than 10000");
            }
            else
            {
                Console.WriteLine("Basic salary is less than 10000 ");
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public Employee(string name = "No name", decimal basic = 2500, short deptNo = 10)
        {
            this.EmpNo = ++empNo;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }


        private string name;
        public string Name
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Enter a Correct Name");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

      
        private static int empNo = 0;
        public int EmpNo
        {
            get;

            private set;
        }

        protected decimal basic;
        public decimal Basic { get; set; }


        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Depart no should be greater then 0");
                }
                else
                {
                    deptNo = value;
                }

            }
            get
            {
                return deptNo;
            }
        }
    }
}
