using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyPoint m;
            //m.x = 100;
            //m.y = 200;

            MyPoint p = new MyPoint();

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);

            //int i = 0;
            //int i = new int();
           // Console.WriteLine(i);
            Console.ReadLine();

        }

        public struct MyPoint
        {
            //can not write parameterless constructor in struct
            //can write parameterised constructor
            //No inheritance is allowed
            //struct is faster than classess becuase for structs memmory alloacates on stack that why struct is faster
            public MyPoint(int x,int y)
            {
                this.x = x;
                this.y = y;
            }

            public int x, y;
        }
    }
}
namespace Day5_NullableValues
{
    class Program
    {
        public static void Main(string [] args)
        {                //nullable type is any type that can be have null value
            int?i = 0;   // Nullable type it means it can store null value
           // Nullable<int> i = 10;
           // i = null;

            int j = 0;
            if(i!=null)
            {
                j = (int)i;
            }
            else
            {
                j = 0;
            }

            if (i.HasValue)   //hasvalue returns true false
                j = i.Value;
            else
                j = 0;

            j = i.GetValueOrDefault();
            j = i.GetValueOrDefault(10);
            j = i ?? 10; //null coalescing operator
                        // if i has a value then value other wise value is 10
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }


}