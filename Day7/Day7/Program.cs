using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_exceptionHandiling
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.p1 = 100 / x;
                Console.WriteLine(obj.p1);
                Console.WriteLine("No Exceptions");
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }

    class Class1
    {
      public  int p1;
    }
}

namespace Cust_Exception
{
    class Program
    {
        static void Main2(string[] args)
        {
            try
            {
                Employee e = new Employee();
                e.I = 9000;
                e.NAME = "";
                e.Display();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
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
                if(value>1000)
                {
                    Exception e;
                    e = new Exception("value greter than 1000");
                    throw e;
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
                if (value ==null || value=="")
                {
                    Exception e;
                    e = new Exception("Null value Exception,Enter valid string");
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
            Console.WriteLine("i : "+I+" "+"Name : "+NAME);
        }

    }
}

namespace SystemExceptions
{
    class Program
    {
         static void Main3(string[] args)
        {
            try
            {
                int i = 10;
               i = Convert.ToInt32(Console.ReadLine());

                
            }catch(FormatException fe)
            {
                Console.WriteLine("format Invalid Exception");
            }

            Console.ReadLine();
        }
    }
}

namespace Userdefined_exception
{
    class Program
    {
        static void Main5(string[] args)
        {
            try
            {
                Employee e = new Employee();
                e.I = 900;
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

    class Employee
    {
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
                    Exception e;
                    e = new Exception("value greter than 1000");
                    throw e;
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

   public class InvalidEmployeeException:ApplicationException
    {
        public InvalidEmployeeException(string msg):base(msg)
        {
                
        }
    }
}