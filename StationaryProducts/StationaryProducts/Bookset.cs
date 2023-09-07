using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryProducts
{
    class Bookset:IStationary
    {/*
        int Books;
        int rate;
        int AvailableQuantity;*/
        public string Bookname { get; set; }
        public int Rate { get; set; }
        public int AvailableQuantity { get; set; }
        List<Bookset> books = new List<Bookset>();
        public void AddItem(IStationary i)
        {
            books.Add((Bookset)i);
        }
        public void Fetch()
        {
            Console.WriteLine("The list of Booksets are");
            Console.WriteLine("Count: " + books.Count);
            foreach (Bookset b in books)
            {
                Console.WriteLine($"Bookset Name : {b.Bookname}\t Bookset Price : {b.Rate}\t Bookset Quantity : {b.AvailableQuantity}");
            }

        }
        public void RemoveItem(IStationary i)
        {
            books.Remove((Bookset)i);
        }
        public int DiscountTotal()
        {
            int bookSetDiscount = AvailableQuantity > 10 ? 15 : 10;
            return (int)(AvailableQuantity * Rate * (100 - bookSetDiscount) / 100.0);


            /* int discount = AvailableQuantity > 10 ? 15 : 10;
             return (int)(AvailableQuantity * Rate * (100 - discount) / 100.0);*/
        }
        public int CalculateBill()
        {
            return AvailableQuantity * Rate;
        }
    }
}
