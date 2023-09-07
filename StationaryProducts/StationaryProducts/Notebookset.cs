using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StationaryProducts
{
    class Notebookset : IStationary
    {
        // public string property with a getter and a setter which stores the name of a notebook.(read and written)
        public string NoteBookName { get; set; }
        // public string property with a getter and a setter which stores the rate of a notebook.(read and written)
        public int NRate { get; set; }
        // public string property with a getter and a setter which stores the quantity of a notebook.(read and written)
        public int NAvailableQuantity { get; set; }
       /* public Notebookset(string name, int rate, int availablequantity)
        {
            NoteBookName = name;
            NRate = rate;
            NAvailableQuantity = availablequantity;
        }*/
        /* int Notebooks;
         int rate;
         int AvailableQuantity;*/
        List<Notebookset> notebooks = new List<Notebookset>();

        public void AddItem(IStationary i)// takes interface as an argument
                                          //object passed to AddItem implements the IStationary interface which is then cast to Notebookset.
                                          
        {
            notebooks.Add((Notebookset)i);// notebooks are added to the notebookset list
        }

        public void Fetch()
        {

            Console.WriteLine("The list of Notebooks are");
            Console.WriteLine("Count: " + notebooks.Count);
            foreach (Notebookset nb in notebooks)
            {
                Console.WriteLine($"TextBook Name : {nb.NoteBookName}\t TextBook Price : {nb.NRate}\t TextBook Qty : {nb.NAvailableQuantity}");
            }
        }
        public void RemoveItem(IStationary i)
        {
            notebooks.Remove((Notebookset)i);
        }
        public int DiscountTotal()
        {

            int notebookSetDiscount = NAvailableQuantity > 10 ? 20 : 10;
            return (int)(NAvailableQuantity * NRate * (100 - notebookSetDiscount) / 100.0);
        }
        public int CalculateBill()
        {
            return NAvailableQuantity * NRate;
        }

    }
}