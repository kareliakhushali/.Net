using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
  internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee details");
            Console.Write("Employee ID: ");
            int _empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary: ");
            int _salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Department: ");
            Department department = (Department)Enum.Parse(typeof(Department), Console.ReadLine());

            Console.Write("Experience: ");
            int experience = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Aadhar Number: ");
            long aadharNo = Convert.ToInt64(Console.ReadLine());

            Employee e = new Employee(_empId, _salary, "Dev", department, experience, name, aadharNo);
            Console.WriteLine($"{e.EmpId} {e.Name} {e.AdharNo} {e.Id} {e.Salary}");
            /*Employee e = new Employee(101, 80000, "Dev", Department.Web, 1, "Kiran", 123456789111);
            Console.WriteLine($"{e.EmpId} {e.Name} {e.AdharNo} {e.Id} {e.Salary}");*/


            Console.Read();
        }
    }
}
