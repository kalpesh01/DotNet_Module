using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee e = new Employee();
                e.I = 2000;
                e.NAME = "";
                e.Display();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }


    public delegate void InvalidEmployeeException();

    class Employee
    {

        //step2: declare the delegae object

      public event  InvalidEmployeeException invemp;
        private int i;
        private string name;

        public int I
        {
            get
            {
                return i;
            }
            set
            {
                if (value > 1000)
                {
                    //raise the event
                    //step3: call the delegate object
                    invemp();
                }
                else
                {
                    this.i = value;
                }
            }
        }

        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null || value == "")
                {
                    Exception e;
                    //e = new Exception("Null value Exception,Enter valid string");

                    //userDefinedException
                    e = new InvalidEmployeeException("Null Value Exception");
                    throw e;
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("i : " + I + " " + "Name : " + NAME);
        }

    }

    public class InvalidEmployeeException : ApplicationException
    {
        public InvalidEmployeeException(string msg) : base(msg)
        {

        }
    }
}
