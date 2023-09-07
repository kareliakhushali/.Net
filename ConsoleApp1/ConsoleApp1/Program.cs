using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age = 22;
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();
            Console.WriteLine($"Your name is {name} and your age is {age}");

            int no1, no2;
            Console.WriteLine("Enter value of no1: ");
            no1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter value of no2: ");
            no2 = Convert.ToInt32(Console.ReadLine());

            int max = no1 > no2 ? no1 : no2;
            Console.WriteLine($"Max : {max}");
            Book b;
            b = new Book();
            b.BookId = 6;
            int id = b.BookId;
            b.Title = "My Book";
            b.Rate = 1000;
            Console.WriteLine($"{b.BookId}" );
            Console.WriteLine( $"{b.Title} : {b.Rate}" );
            Console.Read();


        }
    }
}
