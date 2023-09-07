using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask
{
    class Items
    {
        public void DisplayItems()
        {
             List<string> product = new List<string>();
             Console.WriteLine("Textbook Set ");
             Console.WriteLine("Notebook Set");
             Console.WriteLine("Pen set");
             foreach (object products in product)
             {
                 switch (products)
                 {
                     case 1:
                         Console.WriteLine("You are selected Textbook");
                         break;
                     case 2:
                         break;
                     case 3:
                         break;
                     case 4:
                         Console.WriteLine("You are Exit for Application");
                         break;
                     default:
                         break;
                 }
             }

               while (true)
               {
                   Console.WriteLine("10th TextBook set");
                   string bookset19 = Console.ReadLine();

                   Console.WriteLine("12th TextBook Set");
                   string bookset20 = Console.ReadLine();

                   Console.WriteLine("100 Pages Book");
                   string  noteboook100= Console.ReadLine();

                   Console.WriteLine("200 pages Book");
                   string notebook200= Console.ReadLine();

                   Console.WriteLine("Pen Set");
                   string penset = Console.ReadLine();



               }
            
        }
        public void List()
         {

             List<string> list = new List<string>();
             list.Add("10th bookset");
             list.Add("12th bookset");
             list.Add("notebook 100");
             list.Add("notebook 200");
             list.Add("Pen Set");
             foreach (object each in list)
             {
                 Console.WriteLine(each);
             }
         }
    }
}
