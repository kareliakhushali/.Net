using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticalTask1
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            BookSet book = new BookSet();
            book.AddItem();
            book.Fetch();
            book.CalculateBill();
            book.RemoveItem();
            book.DiscountTotal();
            NoteBook notebook = new NoteBook();
            notebook.AddItem();
            notebook.RemoveItem();
            notebook.CalculateBill();
            notebook.DiscountTotal();
            notebook.Fetch();
            PenSet penset = new PenSet();
            penset.Fetch();
            penset.RemoveItem();
            penset.AddItem();
            penset.CalculateBill();
            penset.DiscountTotal();
            Items item = new Items();
             item.display();
             Console.Read();
            Console.ReadLine();
        }
    }
}
