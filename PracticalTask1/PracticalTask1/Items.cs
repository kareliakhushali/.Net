using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask1
{
    class Items
    {
        public void display()
        {
             List<string> items = new List<string>();
             Console.WriteLine("Book Set ");
             Console.WriteLine("Notebook Set");
             Console.WriteLine("Pen set");
             foreach (object i in items)
             {
                 switch (i)
                 {
                     case 1:
                         Console.WriteLine("You have selected Bookset");
                         break;
                     case 2:
                        Console.WriteLine("You have selected Notebookset")
                         break;
                     case 3:
                         break;
                     case 4:
                         Console.WriteLine("Exit");
                         break;
                     default:
                         break;
                 }
             }

              



               }
            
        }
         public void Data()
         {

             List<string> list = new List<string>();
             list.Add("10th set");
             list.Add("12th set");
             list.Add("100 Pages Notebooks");
             list.Add("200 Page Notebooks");
             list.Add("Pen Set");
             foreach (object each in list)
             {
                 Console.WriteLine(each);
             }
         }
    
}
}
