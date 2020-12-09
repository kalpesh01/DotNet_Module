using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }

    public class ClassDemo:IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose method called");
        }

        void Display()
        {
            Console.WriteLine("Display");
        }
    }
}
