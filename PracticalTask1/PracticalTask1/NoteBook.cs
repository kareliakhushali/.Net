using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask1
{
    class NoteBook:IStationary
    {
        int Notebooks;
        int rate;
        int AvailableQuantity;
        
       public void AddItem()
        {
            Console.Write("NotebookSet:- ");
            Notebooks = Convert.ToInt32(Console.ReadLine());
            Console.Write("NoteBook rate:-");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantity:- ");
            AvailableQuantity = Convert.ToInt32(Console.ReadLine());
        }
        public void Fetch()
        {
            Console.WriteLine($"NoteBookSet:- {Notebooks}");
            Console.WriteLine($"NoteBook rate:- {rate}");
            Console.WriteLine($"Quantity:- {AvailableQuantity}");

        }
        public void RemoveItem()
        {
            throw new NotImplementedException();
        }

       public int DiscountTotal()
        {
            int discount = AvailableQuantity > 10 ? 15 : 10;
          return (int)(AvailableQuantity * rate * (100 - discount) / 100.0);
        }
      public  int CalculateBill()
        {
            return AvailableQuantity * rate;

        }
    }
}
