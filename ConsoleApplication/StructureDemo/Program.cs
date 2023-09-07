using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Person ID:");
            int _personId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Person Name:");
            string _name = Console.ReadLine();

            Console.WriteLine("Enter Person Salary:");
            int _salary = int.Parse(Console.ReadLine());

            Person p = new Person(_personId, _name, _salary);


            Person p1 = new Person(_personId, _name, _salary);


            //Person p = new Person(1, "Jay", 6000);
            //Person p1 = new Person(1, "jay", 6000);
            if (p.ComparePerson(p1))
            {
                Console.WriteLine("Both the objects are same");
            }
            else
            {
                Console.WriteLine("Objects are not same");
            }
            Console.WriteLine($"PersonID {p.GetPersonId()}");
            Console.WriteLine(p.Name);
            Console.Read();
        }
    }
}
