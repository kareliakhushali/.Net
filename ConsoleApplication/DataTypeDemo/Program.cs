using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max{0}" + int.MaxValue);
            Console.WriteLine("Min{0}" + int.MinValue);

            int data = int.MaxValue;
            unchecked
            {
                int value = int.MaxValue + 1;
                Console.WriteLine("Value:"+ value);
            }
            try
            {
                checked
                {
                    Console.WriteLine("Value: "+ (data+1));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

           // int no = 5;
            //boxing value to object type(Implicit)
          //  object o = no;
           // Console.WriteLine("Object: " + o);
            //unboxing the object to value type(Explicit)
           // int no1 = (int)o;
          //  Console.WriteLine("no1 :" + no1);
            //            Console.WriteLine("No1 ={0}" + no1);
            // Console.WriteLine($"No1={no1}");
            object o = 10;
            long l = 12L;
            int val = 20;
            bool b = false;
            Print(l);
            Print(val);
            Print(b);
            Print('A');
            Print(o);
            sbyte svalue = sbyte.MinValue + 10;
            Print((object)svalue);
            Student student = new Student()
            {
                StudentId = 1,
                Marks = 300,
                Name = "khushali Karelia"
            };
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Salary = 60000,
                Name = "Murali Chobey"
            };
            Employee emp;
            emp.EmployeeId = 101;
            emp.Name = "jay Patel";
            emp.Salary = 10000;
            Data.Method(student);
            Data.Method(employee);
            Console.Read();

        }
        static void Print(Boolean b)
        {
            Console.WriteLine($"Type {b.GetType()} and Value {b}");
        }
        static void Print(int value)
        {
            Console.WriteLine($"Type {value.GetType()} and Value {value}");
            Console.WriteLine($"Min value {int.MinValue} Max value{int.MaxValue}");

        }
        static void Print(long value)
        {
            Console.WriteLine($"Type {value.GetType()} and Value {value}");
            Console.WriteLine($"Min value {long.MinValue} Max value{long.MaxValue}");

        }
        static void Print(char ch)
        {
            Console.WriteLine($"Type {ch.GetType()} and Value {ch}");
            Console.WriteLine($"Min value {char.MinValue} Max value{char.MaxValue}");

            Console.WriteLine($"Min value integer {(int)char.MinValue} Max value{(int)char.MaxValue}");


        }
        static void Print(object o)
        {
            Console.WriteLine($"Type {o.GetType()} and value{o}");
            Type objType = o.GetType();
            if(objType == typeof(int))
            {
                Console.WriteLine($"Min value {int.MinValue} Max value{int.MaxValue}");


            }
            else if(objType == typeof(long))
            
                Console.WriteLine($"Min value {long.MinValue} Max value{long.MaxValue}");
            else if(o is sbyte)

                Console.WriteLine($"Min value {sbyte.MinValue} Max value{sbyte.MaxValue}");


        }

    }
}
