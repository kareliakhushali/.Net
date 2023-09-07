using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4._0Features
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic runtime;
            runtime = "khushi";
            Console.WriteLine($"{runtime} {runtime.GetType()}");
            runtime = 1234;
            Console.WriteLine($"{runtime}{runtime.GetType()}");
            Console.WriteLine($"1+5 = {DynamicMethod(1, 5)}");
            Console.WriteLine($"ABC+XYZ = {DynamicMethod("ABC","XYZ")}");
            Console.WriteLine($"123+XYZ = {DynamicMethod(123, "XYZ")}");
            Console.WriteLine($"12.34+XYZ = {DynamicMethod(12.34, "XYZ")}");
            Console.WriteLine($"12.34+XYZ = {DynamicMethod(12.34, "XYZ")}");
            Console.WriteLine($"1+3 = {Method(1, 3)}");
            Console.WriteLine($"1+Default(4) = {Method(1)}");
            Console.WriteLine($"4+1 using named = {Method(n2:1,n1:4)}");
            Console.WriteLine($"5+4 using named = {Method(5, n2:4)}");





            Console.Read();   
        }
        public static dynamic DynamicMethod(dynamic arg1,dynamic arg2)
        {
            var ans = arg1 + arg2;
            return ans;
        }
        //optional parameter should be followed by positional parameter
        public static int Method(int n1,int n2=4)
        {
            return n1 + n2;
        }
    }
}
// var is statically typed and dynmaic is dynamically typed
//var need to be initialized
//multiple initialization with diff type is not allowed in var
//var is not used as method parameter and return type
