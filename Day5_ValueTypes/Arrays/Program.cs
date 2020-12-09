using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[5];

            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter element no {0}",i);   //{0} placeholder 
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            // Array.Clear(arr,0,5);
            //Array.Copy(arr, arr2, 5);
            //Array.ConstrainedCopy
            //Array.CreateInstance(typeof(int), 0);
            //int pos = Array.IndexOf(arr,10); //returns -1 if not found
            //int pos = Array.lastIndexOf(arr,10); //returns -1 not found
            //int pos = Array.BinarySearch(arr,10);//returns -1 if not found
            //Array.Reverse(arr);
            //Array.Sort(arr);
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }




            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            //two diamenional array
            int[,] arr2 = new int[5,3];

            Console.WriteLine(arr2.Length);  //15
            Console.WriteLine(arr2.GetLength(0));  //5
            Console.WriteLine(arr2.GetLength(1));  //4
            Console.WriteLine(arr2.Rank);  // return 2 it tells what dimensional array

            Console.WriteLine(arr2.GetUpperBound(0));  //4
            Console.WriteLine(arr2.GetUpperBound(1));  //2
            Console.WriteLine(arr2.GetLowerBound(0));  //0
            Console.WriteLine(arr2.GetUpperBound(1));  //0
            for (int i=0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write("Enter marks for student number {0} and subject {1}",i,j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                } 
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter marks for student number {0} and subject {1} is {2}", i, j,arr2[i,j]);
                   
                }
            }

            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            //marks for 5 students 3 marks
            //int [,]=new int[5,3]

            //5 rows, each row has 3 cols
            //5 rows , each row has diff cols
            // array of arrays
            //int [] [] arr = new int [2][]   //jagged array
            //arra[0]=new int [138]
            //arra[1]=new int [112]


        }

    }


}
