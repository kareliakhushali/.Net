using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3_0Features
{
    class Program
    {
        static void Main(string[] args)
        { 
            // only use with local variable
            var no = 5;
            //not allowed
            //var value1;
            //null initialized not allowed
            //var value1 = null
            Console.WriteLine(no.GetType());
            //not posssibel
            //   no = "khushali"
            //implicitly typed array
            var items = new[] { "Java", "C++", "Python", "C" };
          //  var result = items.Where(item => item.StartsWith("C")).ToList();
           
            Array.ForEach(items, each => Console.WriteLine($"{each}:{each.Length}"));
            Array.ForEach(items, each => Console.Write(each[0] == 'C' ? each + "\t" : ""));
            Console.WriteLine();
            // object intialized inside a pair of curly brackets{}
            //we intialize members of class through series of assignments
            Person p = new Person() { Id = 1, Name = "khushi" };

            //collection Initializers
            List<Person> list = new List<Person>()
            {
new Person() {Id =1,Name ="khushi"},
new Person() {Id =2,Name ="khushali"},

            };
            //Anonymous types are allowed data types to encapsulate a set
            // of properties into a single object without having to first
            //explicitely define a type.Anonymous types must be stored in variables declared with var keyword
            var student = new { Name = "Jay", RollNo = 5 };
            Console.WriteLine($"{student.RollNo} : {student.Name}");
            Console.WriteLine(student.GetType());

            string name = "khushali";
            int digit = "khushi123".CountDigit();
            Console.WriteLine(digit);
            String[] names = { "khushi", "Khushali", "Bhumika", "Hemant" };
            var result = (from each in names where each.Length >= 6 select each).ToArray();
            Array.ForEach(result, each => Console.WriteLine(each));
            Console.WriteLine(name.LowerUpper());
            Console.WriteLine(name.CountDigit());
            Console.Read();
        }
    }
    class Person
    {
        //Auto Implemented Property
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public static class StringExtension
    {
        public static string LowerUpper(this string value)
        {
            string reply = "";
            foreach(char ch in value)
            {
                if (char.IsUpper(ch))
                    reply += Char.ToLower(ch);
                else if (char.IsLower(ch))
                    reply += Char.ToUpper(ch);
                else
                    reply += ch;
            }
            return reply;
        }
        public static string CountDigit(this string value)
        {
            int cnt = 0;
            foreach (char ch in value)

                cnt += char.IsDigit(ch) ? 1 : 0; 
              if(char.IsDigit(ch) )
                {
                    cnt++;
                }
                   
            }
            return cnt;
        }
    }
}
