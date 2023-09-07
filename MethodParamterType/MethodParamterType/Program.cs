using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParamterType
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------Pass-By-Value----------------");
            Console.WriteLine($"In main method before calling function:{value}");
            PassByValue(value, 5);
            Console.WriteLine($"In main method after calling function:{value}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("-----------------Pass-By-Reference----------------");
            value = 10;
            Console.WriteLine($"In main method before calling(Ref)function:{value}");
            PassByReference(ref value, 5);
            Console.WriteLine($"In main method after calling(Ref)function:{value}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            value = 0;

            Console.WriteLine("-----------------Pass-By-Out----------------");
            Console.WriteLine($"In main method before calling PassByOut method:{value}");
            PassByOut(out value);
            Console.WriteLine($"In main method after calling PassByOut method:{value}");
            Console.Read();




        }
        static void PassByValue(int value,int changeApply)
        {
            Console.WriteLine("Before Applying change: {0} inside method", value);
            value = value + changeApply;
            Console.WriteLine($"After Applying change inside method {value}");

        }
        //All ref parameters need to be initialized  before entering the method
        static void PassByReference(ref int value,int changeAppply)
        {
            Console.WriteLine("Before Applying change: {0} inside method", value);
            value = value + changeAppply;
            Console.WriteLine($"After Applying change inside method {value}");
        }
        static void PassByOut(out int value)
        {
            value = 10;
            Console.WriteLine($"Pass by Out value inside method: {value}");
        }
        
       
    }
    }

