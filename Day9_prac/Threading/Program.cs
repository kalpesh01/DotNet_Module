using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before");
           // Action<string> o = Display;
            Func<string, string> o1 = Display1;
            //o();   will invoke the display method
            //o.BeginInvoke(null,null);
            //o.BeginInvoke("abc",null, null);
            //Console.WriteLine("After");

            //o1.BeginInvoke("abc1",CallBackFunc, null);
            o1.BeginInvoke("abc1", delegate(IAsyncResult ar)
            {
                Console.WriteLine("Callback Function called" );
                string retval = o1.EndInvoke(ar);
                Console.WriteLine("retval "+retval);
            }, null);


            Console.ReadLine();
        }

        static void Display()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display");
        }
        static void Display2(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display");
        }
        static string Display1(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display");
            return s;
        }

        static void CallBackFunc(IAsyncResult ar)
        {
            Console.WriteLine("Callback Function called"+ ar);
        }
    }
}
