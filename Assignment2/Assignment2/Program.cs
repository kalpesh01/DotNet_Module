using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager m = new Manager("mg","kalpesh",12000,10);
            Console.WriteLine("Employee Id : "+m.EMPNO);
            Console.WriteLine(m.NAME + "   " + m.BASIC);
            Console.WriteLine("Netsal : " + m.net_salary());
            Console.ReadLine();

            Console.WriteLine("********************");
            Manager m2 = new Manager("mg","kalpesh");
            Console.WriteLine("Employee Id : "+m2.EMPNO);
            Console.WriteLine(m2.NAME + "   " + m2.BASIC);
            Console.WriteLine("Netsal : " + m2.net_salary());
            Console.ReadLine();

            GeneralManager gm = new GeneralManager("hjs","clr", "rahul", 14000, 14);
            Console.WriteLine("Employee Id : " + gm.EMPNO);
            Console.WriteLine(gm.NAME + "   " + gm.BASIC +"   "+gm.PERKS);
            Console.WriteLine("Netsal : " + gm.net_salary());
            Console.ReadLine();


            CEO ceo = new CEO("Hitesh", 55000, 18);
            Console.WriteLine("Employee Id : " + ceo.EMPNO);
            Console.WriteLine(ceo.NAME + "   " + ceo.BASIC );
            Console.WriteLine("Netsal : " + ceo.net_salary());
            Console.ReadLine();


        }
    }


   public abstract class Employee
    {
        private string Name;

        private static int normEmpNo = 0;
        private int empNo;
        private short DeptNo;
        private  decimal Basic;

        public string NAME
        {
            set
            {
                if (value == "" || value == null)
                {

                }
                else
                {
                    Name = value;
                }
            }
            get
            {
                return Name;
            }
        }

        public abstract decimal BASIC
        {
            set;
            get;
        }
        public decimal DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    Basic = value;
                }

            }
            get
            {
                return DeptNo;
            }
        }
        public int EMPNO
        {
            private set { empNo = value; }   //property Accessor

            get
            { return empNo; }
        }


        public Employee(string Name = "Default", decimal Basic = 1000, short DeptNo = 10)
        {
            this.NAME = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
            empNo = ++normEmpNo;
            
        }


        public abstract decimal net_salary();

       

        
    }
    class Manager : Employee
    {
        private string Designation;
        public Manager(string Designation="mg",string Name = "Default", decimal Basic = 1000, short DeptNo = 10):base( Name, Basic, DeptNo )
        {
            this.NAME = Name;
            this.BASIC = Basic;
            this.DEPTNO = DeptNo;
            this.DESIGN = Designation;
        }
        

        public string DESIGN
        {
            set
            {
                if (value == "" || value == null)
                {

                }
                else
                {
                    Designation = value;
                }
            }
            get
            {
                return Designation;
            }
        }

        public override decimal BASIC
        {
            get;
            set;
        }
        public override decimal net_salary()
        {
            decimal da = BASIC * (decimal)0.52;
            decimal gross_salary = BASIC + da;
            decimal it = gross_salary * (decimal)0.30;
            decimal net_salary = (BASIC + da) - it;
            return net_salary;
        }
    }

     class GeneralManager : Manager
    {
        
        private string Perks;


        public GeneralManager(string Perks="abc",string Designation = "mg", string Name = "Default", decimal Basic = 1000, short DeptNo = 10) : base(Designation,Name, Basic, DeptNo)
        {
            this.NAME = Name;
            this.BASIC = Basic;
            this.DEPTNO = DeptNo;
            this.DESIGN = Designation;
            this.PERKS = Perks;
        }
        public override decimal BASIC
        {
            get;
            set;
        }
        

        public string PERKS
        {
            get;set;
        }

        public override decimal net_salary()
        {
            decimal da = BASIC * (decimal)0.52;
            decimal gross_salary = BASIC + da;
            decimal it = gross_salary * (decimal)0.30;
            decimal net_salary = (BASIC + da) - it;
            return net_salary;
        }
    }


    class CEO : Employee
    {

        public CEO(string Name = "Default", decimal Basic = 1000, short DeptNo = 10): base(Name, Basic, DeptNo)
        {
            this.NAME = Name;
            this.BASIC = Basic;
            this.DEPTNO = DeptNo;
        }
        public override decimal BASIC
        {
            get;
            set;
        }
        public sealed override decimal net_salary()
        {
            decimal da = BASIC * (decimal)0.52;
            decimal gross_salary = BASIC + da;
            decimal it = gross_salary * (decimal)0.30;
            decimal net_salary = (BASIC + da) - it;
            return net_salary;
        }
    }
}


