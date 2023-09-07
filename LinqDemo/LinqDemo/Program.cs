using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 4, Name = "Fourth Employee", Age = 18 });
            employees.Add(new Employee() { Id = 2, Name = "Second Employee", Age = 35 });
            employees.Add(new Employee() { Id = 5, Name = "Fifth Employee", Age = 29 });
            employees.Add(new Employee() { Id = 3, Name = "Third Employee", Age = 19 });
            employees.Add(new Employee() { Id = 1, Name = "First Employee", Age = 20 });


            Console.WriteLine("List of Employees in the collection");
            foreach(Employee e in employees)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);

            }
            Console.WriteLine();
            Employee[] employeesCopy = new Employee[employees.Count];
            employees.CopyTo(employeesCopy);
            Array.Sort(employeesCopy);
            Console.WriteLine("list of employees in the collection after sorting (IComparable)");
            foreach(Employee e in employeesCopy)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();

            Console.WriteLine("List of employees in Descending order of ID");
            for(int i = employeesCopy.Length-1; i > -1; i--)
            {
                Console.WriteLine("{0} {1,-20} {2}", employeesCopy[i].Id, employeesCopy[i].Name, employeesCopy[i].Age);
            }
            Console.WriteLine();
            Console.WriteLine("list of employees in the collection(ORIGINAL DATA)");
            foreach(Employee e in employees)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            //LINQ
            var query = from e in employees
                        orderby e.Name
                        select e;
            Console.WriteLine("List of employees in the collection - After sorting");
            foreach(Employee e in query)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();
            Console.WriteLine("List of employees in the collection Original data");
            foreach (Employee e in employees)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();
            Console.WriteLine("list of employees in the collection and filtering it in original data");
            foreach (Employee e in employees)
            {
                if(e.Age < 30)
                {
                    Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);

                }
            }
            Console.WriteLine();
            var query2 = from e in employees
                         where e.Age < 30
                         orderby e.Age descending
                         select e;
            Console.WriteLine("List of employees in the collection- After filtering");
            foreach (Employee e in query2)
            {
                
                    Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();

            //LINQ with projection
            var query3 = from e in employees
                         select new //anonymous object
                         {
                             ObjectId = e.Id,
                             e.Name,
                             e.Age,
                             Address = $"Address #{e.Id} Some City"
                         };
            Console.WriteLine("List of objects using LINQ after Projection");
            foreach(var e in query3)
            {
                Console.WriteLine("{0} {1,-20} {2} {3}", e.ObjectId, e.Name, e.Age,e.Address);

            }
            Console.WriteLine();

            var qla = from e in employees
                      select e;
            var qlb = employees.Select(e => e);

            var q2a = from e in employees
                      where e.Age < 30
                      select e;
            var q2b = employees.Where(e => e.Age < 30);
            var q3a = from e in employees
                      orderby e.Name descending
                      where e.Age < 30
                      select e;
            var q3b = employees.Where(e => e.Age < 30)
                .OrderByDescending(e => e.Name);
            var q2c = from e in q2a
                      orderby e.Name descending
                      select e;
            foreach(var e in q2c)// LINQ query will execute here
            {

            }
            Employee thirdemployee = (from e in employees
                                      where e.Id == 3
                                      select e).SingleOrDefault();
            bool doesSharmaExist = employees.Any(e => e.Name == "Sharma");
            var paginatedEmployees = employees.Skip(2).Take(3);
            var paginatedEmployees2 = (from e in employees
                                       select e).Skip(2).Take(3);
            int maxage = employees.Max(each => each.Age);
            var result = from each in employees where each.Age == maxage select each;
            int minage = employees.Min(each => each.Age);
            var result1 = from each in employees where each.Age == minage select each;
            int average = 
            Console.Read();

        }
    }
}
