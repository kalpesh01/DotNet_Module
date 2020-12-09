using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Note:- 
//1.Polymorphic Behaviour 
//
namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDemo obj = new ClassDemo();
            ClassDemo1 obj2 = new ClassDemo1();
            /*obj.Insert();
            obj.Delete();
            obj.Update();*/

            InsertMethod(obj);
            InsertMethod(obj2);
            Console.ReadLine();


            IDbFunctions oIDb;
            oIDb = obj;
           oIDb.Insert();
          
          

        }

        //generic method 
        //pass the  object of class  whos implements IDbFunctions Interface
        static  void InsertMethod(IDbFunctions oIDb)
        {
            oIDb.Insert();
        }
    }

   

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

    }

    public class ClassDemo1 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete Method1");
        }

        public void Insert()
        {
            Console.WriteLine("Insert Method1");
        }

        public void Update()
        {
            Console.WriteLine("Update Method1");
        }

        public void Display()
        {
            Console.WriteLine("Display Method1");
        }
    }
    public class ClassDemo : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete Method");
        }

        public void Insert()
        {
            Console.WriteLine("Insert Method");
        }

        public void Update()
        {
            Console.WriteLine("Update Method");
        }

        public void Display()
        {
            Console.WriteLine("Display Method");
        }
    }
}

namespace interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDemo1 obj = new ClassDemo1();
            IFileFunction oIFile;
            oIFile = obj;
            oIFile.Open();
            oIFile.Close();
            



        }

        //generic method 
        //pass the  object of class  whos implements IDbFunctions Interface
        static void InsertMethod(IDbFunctions oIDb)
        {
            oIDb.Insert();
        }
    }



    public interface IDbFunctions 
    {
        void Insert();
        void Update();
        void  Delete();

    }

    public interface IFileFunction
    {
        void Open();
        void Close();
        void Delete();

    }

    public class ClassDemo1 : IDbFunctions, IFileFunction
    {
        public void Delete()
        {
            Console.WriteLine("Delete Method1");
        }

        public void Insert()
        {
            Console.WriteLine("Insert Method1");
        }

        public void Update()
        {
            Console.WriteLine("Update Method1");
        }

        public void Display()
        {
            Console.WriteLine("Display Method1");
        }

        void IFileFunction.Open()
        {
            Console.WriteLine("IFile.Open");
        }

        void IFileFunction.Close()
        {
            Console.WriteLine("IFile.Close");
        }

        void IFileFunction.Delete()
        {
            Console.WriteLine("IFile.Delete");
        }
    }
    public class ClassDemo : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete Method");
        }

        public void Insert()
        {
            Console.WriteLine("Insert Method");
        }

        public void Update()
        {
            Console.WriteLine("Update Method");
        }

        public void Display()
        {
            Console.WriteLine("Display Method");
        }
    }
}
