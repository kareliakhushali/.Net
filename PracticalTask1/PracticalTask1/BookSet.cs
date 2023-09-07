using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask1
{
    class BookSet : IStationary
    {
        int book;
        int rate;
        int AvailableQuantity;


        List<int> books = new List<int>();
       public void AddItem()
        {
           
            books.Add(book);
            books.Add(rate);
            books.Add(AvailableQuantity);
        }
        public void Fetch()
        {
            var res = from s in books
                      select s;

        }
        public void RemoveItem()
        {
            books.Remove(book);
            books.Remove(rate);
            books.Remove(AvailableQuantity);
        }


        public int DiscountTotal()
        {
            return AvailableQuantity;
        }
        public int CalculateBill()
        {
            return AvailableQuantity * rate;

        }
        

        
        

        
      
    }
    
}
