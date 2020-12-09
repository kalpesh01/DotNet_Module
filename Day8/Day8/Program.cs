using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_ActionParameters
{
    class Program
    {
        static void Main1(string[] args)
        {
            Action obj = Display;
            obj();

            Action<int> obj1 = Display;
            obj1(10);
            Action<int,string> obj2 = Display;
            obj2(200,"Hello Good Morning");
            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("Display Method Called");
        }

        static void Display(int a)
        {
            Console.WriteLine("Display Method Called with parameter 1");

        }
        static void Display(int a, string name)
        {
            Console.WriteLine("Display Method Called " + a +" "+name);

        }
    }

    
}
namespace Day8_Func
{
    class Program
    {
        static void Main2(string[] args)
        {
            Func<int,int,int> obj = Add;
            Console.WriteLine(obj(10,20));
            Console.ReadLine();

            Predicate<int> obj4 = IsEven;
            Console.WriteLine(obj4(10));
            Console.ReadLine();
        }
        static int Add(int a,int b)
        {
            return a + b;
        }

       static bool IsEven(int no)
        {
            return no % 2 == 0;
        }
    }
}
namespace Day8_Anonymous
{
    class Program
    {
        static void Main3(string[] args)
        {
            int i=0;
            Action obj = delegate { Console.WriteLine("Hello I am Anonymous Function"); ++i; };
            obj();
            Console.WriteLine("Value : "+i);

            Func<int, int> obj2 = delegate (int a)
             {
                 return a;
             };

            
            Console.WriteLine(obj2(20));

            Func<int, int,int,long> obj3 = delegate (int a,int b,int c)
            {
                return a+b+c;
            };

            Console.WriteLine(obj3(40,89,34));
            Console.ReadLine();
        }

       

        static int Display1(int a)
        {
            Console.WriteLine(""+a);
            return a;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static bool IsEven(int no)
        {
            return no % 2 == 0;
        }
    }
}
namespace Day8_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            //lamda function
            Func<int, int> obj = a => a + 8;
            Console.WriteLine(" Lamda Function Calling  "+obj(2));

            Func<int, int,int> obj2 = (a,b) =>  a + b;
            Console.WriteLine(obj2(2,3));
            Console.ReadLine();
        }



        static int Display1(int a)
        {
            Console.WriteLine("" + a);
            return a;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static bool IsEven(int no)
        {
            return no % 2 == 0;
        }
    }
}