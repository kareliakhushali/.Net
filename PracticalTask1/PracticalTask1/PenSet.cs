using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask1
{
    class PenSet:IStationary
    {
        int Penset;
        int rate;
        int AvailableQuantity;
     public void AddItem()
        {
            Console.Write("PenSet:- ");
            Penset = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pen rate:-");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantity:- ");
            AvailableQuantity = Convert.ToInt32(Console.ReadLine());
        }
       public void Fetch()
        {
            Console.WriteLine($"PenSet:- {Penset}");
            Console.WriteLine($"Pen rate:- {rate}");
            Console.WriteLine($"Quantity:- {AvailableQuantity}");

        }
        public void RemoveItem()
        {
            throw new NotImplementedException();
        }

      
        public int CalculateBill()
        {
            return AvailableQuantity * rate;

        }

        
    }
}
