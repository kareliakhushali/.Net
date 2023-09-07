using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayDemo
{
  internal  class Program
    {
        static void Main(string[] args)
        {
            int[] noArray = { 1, 2, 3, 4 };
            Console.WriteLine(noArray.Length);

            int[] noArray2 = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(noArray2.Length);

            int[] noArray3 = new int[5];
            Console.WriteLine(noArray3.Length);

            int[] dynamicArray;
            int size;
            Console.Write("Enter the size of array:");
            bool success = int.TryParse(Console.ReadLine(), out size);
            if(success)
            {
                dynamicArray = new int[size];
            }
            else
            {
                Console.Beep();
                dynamicArray = new int[1];
                Thread.Sleep(500);
            }
            Console.WriteLine($"Size of dynamic array:{dynamicArray.Length}");
            Console.WriteLine("Value of noArray2");
            PrintArray(noArray2);
            Console.WriteLine();
            Console.WriteLine("Value of dynamic array");
            PrintArray(dynamicArray);
            Console.WriteLine();
            Console.WriteLine("value of Param Parameter");
            PrintParam(3, 4, 5, 1, 2, 45, 22, 44, 66, 11);
           
            

            int row = 2;
            int col = 3;
            int[,] d2 = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 }
            };
            Console.WriteLine(d2.Length);
            Console.WriteLine(d2.GetLength(0));//for Rows
            Console.WriteLine(d2.GetLength(1));// for cols

            int s = 0;
            foreach(int v in d2)
            {
                Console.WriteLine(v.GetType().ToString() + ":" + v + "\t");
            }
            int[][] jarray = new int[3][];
            jarray[0] = new int[2] { 1, 2 };
            jarray[1] = new int[3] { 3,4,5 };
            jarray[2] = new int[1] { 5 };

            foreach(int[] v in jarray)
            {
                s = 0;
                Array.ForEach(v, each => s += each);
                Console.WriteLine(s);
            }


            Console.Read();

        }
        static void PrintArray(int[] arr)
        {
            foreach (int value in arr)
                Console.Write($"{value}/t");
        }
        static void PrintParam(int a , params int[] arr)
        {
            foreach(int value in arr)
                Console.Write($"{value}/t");

        }
        
        /*static void MaxMin(out int max, out int min ,params int[] arr)
        {
            min = max = arr[0];

            foreach (int value in arr)
            {
                if(value>max)
                {
                    max = value;
                }
             else if(value<min)
                {
                    min = value;
                }
            }
        }/*

       
       /* static void MaxMin(params int[] numbers )
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }

               else if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"Max value: {max}");
            Console.WriteLine($"Min value: {min}");
        }*/
       static void MaxMin(out int min,out int max,params int[] arr)
        {
            int tmax, tmin;
            tmin = tmax = arr[0];
            Array.ForEach(arr, each => tmax = each > tmax ? each : tmax);
            Array.ForEach(arr, each => tmin = each > tmin ? tmin : each);
            max = tmax;
            min = tmin;

        }
    }
}
