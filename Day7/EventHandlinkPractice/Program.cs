using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlinkPractice
{
    class Program
    {
        static void Main1(string[] args)
        {
            Employee e = new Employee();

            e.InvEmp += objeMethod_InvalidEmpNo;
            e.InvEmp += objeMethod_InvalidEmpNo11;

            e.EMPNO = 45;
            Console.WriteLine(e.EMPNO);
            Console.ReadLine();

            Console.WriteLine("*************************************************");
           // e.InvEmp -= objeMethod_InvalidEmpNo;
           // e.InvEmp -= objeMethod_InvalidEmpNo11;

            e.EMPNO = 444;
            Console.WriteLine(e.EMPNO);
            Console.ReadLine();
        }


        static void objeMethod_InvalidEmpNo11()
        {
            Console.WriteLine("Handler Method 2..........");
        }

        static void objeMethod_InvalidEmpNo()
        {
            Console.WriteLine("InvalidEmpNo event code here");
        }
    }

    //step1:Create Delegate
    public delegate void InvalidEmpNoEventHandler();
    public class Employee
    {
        public event InvalidEmpNoEventHandler InvEmp;
        
        private int EmpNo=0;


       
        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
            set
            {
                if(value<100)
                {
                    this.EmpNo = value;
                }
                else
                {
                   //Raise the Event From Here
                    InvEmp();    // 1
                }
            }
        }
    }
}



namespace EventHandlinkPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();

            e.InvEmp += objeMethod_InvalidEmpNo;
           

            e.EMPNO = 45;
            Console.WriteLine(e.EMPNO);
            Console.ReadLine();

            Console.WriteLine("*************************************************");
            // e.InvEmp -= objeMethod_InvalidEmpNo;
            // e.InvEmp -= objeMethod_InvalidEmpNo11;

            e.EMPNO = 444;
            Console.WriteLine(e.EMPNO);
            Console.ReadLine();
        }


        

        static void objeMethod_InvalidEmpNo(int val)
        {
            Console.WriteLine("InvalidEmpNo event code here"+val);
        }
    }

    //step1:Create Delegate
    public delegate void InvalidEmpNoEventHandler(int val);
    public class Employee
    {
        public event InvalidEmpNoEventHandler InvEmp;

        private int EmpNo = 0;


        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
            set
            {
                if (value < 100)
                {
                    this.EmpNo = value;
                }
                else
                {
                    //Raise the Event From Here
                    if (InvEmp != null)
                        InvEmp(value);    // 1
                }
            }
        }
    }
}
