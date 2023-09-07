using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask
{
   
    class Program
    {
        static void Main(string[] args)
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

           /* foreach (IStationary item in items)
            {
                Console.Write($"Enter available quantity of {item.Name}: ");
                int availableQuantity = int.Parse(Console.ReadLine());
                item.AvailableQuantity = availableQuantity;
            }

            int totalBill = 0;
            foreach (IStationary item in items)
            {
                totalBill += item.CalculateBill();
            }
            */
            //Console.WriteLine($"Total bill amount: {totalBill}");
        }
    }

}
