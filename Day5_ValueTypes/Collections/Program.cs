using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collections
{
    class Program
    {
        //hashtable
        static void Main1(string[] args)
        {
            Hashtable obd= new Hashtable();
            obd.Add(1,"abc");
            obd.Add(2, "er");
            obd.Add(3, "dfd");
            obd.Add(4 ,"sdf");

            foreach(DictionaryEntry d in obd)
            {
                Console.WriteLine(d.Key);
                Console.WriteLine(d.Value);
            }
            Console.ReadLine();
        }

        //sortedList
        static void Main2(string[] args)
        {

            //Hashtable obd = new Hashtable();
            SortedList obd = new SortedList();
            obd.Add(1, "abc");
            obd.Add(2, "er");
            obd.Add(3, "dfd");
            obd.Add(4, "sdf");

            obd[3] = "changed value";
            obd[4] = "****";
            foreach (DictionaryEntry d in obd)
            {
                Console.WriteLine(d.Key);
                Console.WriteLine(d.Value);
            }
            Console.ReadLine();
        }

        static void Main3(string[] args)
        {

            //Hashtable obd = new Hashtable();
            SortedList obd = new SortedList();
            obd.Add(1, "abc");
            obd.Add(2, "er");
            obd.Add(3, "dfd");
            obd.Add(4, "sdf");

            obd[3] = "changed value";
            obd[4] = "kk";

            // obd.Remove(4);  // remove using value
            //obd.RemoveAt(2); //remove using index

            Console.WriteLine(obd.GetByIndex(2));
            foreach (DictionaryEntry d in obd)
            {
                Console.WriteLine(d.Key);
                Console.WriteLine(d.Value);
            }
            Console.ReadLine();
        }

        static void Main4(string[] args)
        {
            Stack s = new Stack();

            s.Push(10);
            s.Push(20);
            s.Push(150);
            s.Push(70);

            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine("************************************************");
            Queue q = new Queue();
            q.Enqueue(200);
            q.Enqueue(400);
            q.Enqueue(500);
            q.Enqueue(600);

            Console.WriteLine(q.Count);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Count);

            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            List<int> ol = new List<int>();
            ol.Add(20);
            ol.Add(30);

            foreach(int a in ol)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
