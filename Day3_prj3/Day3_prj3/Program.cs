using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_prj3
{
    //Inheritance
    class Program
    {
        static void Main(string[] args)
        {
            /*int i;
            Console.WriteLine("Enter the number");
            i =int.Parse( Console.ReadLine());
            Console.WriteLine("Integer : "+i);

            i = Convert.ToInt32(Console.ReadLine());*/  // convert.ToInt32 internally calls int.Parse
                                                        //int.Parse is morefaster than Convert.ToInt32
            BaseClass b = new DerivedClass();
            b.display();
            Console.ReadLine();

        }

        
    }

    class BaseClass
    {
        
        public  void  display()
        {
            Console.WriteLine("base display");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("derived  class");
        }

       public new void display()
        {
            Console.WriteLine("derived display");
        }
    }


    
}

namespace Constructors_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            class3 obj = new class3();
            Console.ReadLine();
            
        }
    }


    public  class class1
    {

        public class1()
        {
            Console.WriteLine("Base class Constructor");
        }

        public void Display()
        {
            Console.WriteLine("Base class Display method");
        }
    }

    public  class class2 : class1
    {

        public class2()
        {
            Console.WriteLine("Derived class Constructor");
        }
        public new void Display()
        {
            Console.WriteLine("Derived class Display method");
        }
    }

    public  class class3 : class2
    {
        public class3()
        {
            Console.WriteLine("SubDerived class Constructor");
        }
    }
}


namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            class3 obj = new class3();
            obj.Display();
            Console.ReadLine();

        }
    }


    public abstract class class1
    {

        public class1()
        {
            Console.WriteLine("Abstract Base class Constructor");
        }

        public abstract void Display();
    }

    public class class2 : class1
    {

        public class2()
        {
            Console.WriteLine("Abstract Derived class Constructor");
        }
       

        public override void Display()
        {
            Console.WriteLine("Abstrct Overriden method in class2");
        }
    }

    public class class3 : class2
    {
        public class3()
        {
            Console.WriteLine(" Abstract SubDerived class Constructor");
        }
        public override void Display()
        {
            Console.WriteLine("Abstrct Overriden method in class3");
        }
    }
}

