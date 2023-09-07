using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryProducts
{
    class Penset : IStationary
    {
        public string PenName { get; set; }
        public int Rate { get; set; }
        public int AvailableQuantity { get; set; }
        List<Penset> pensets = new List<Penset>();
        public void AddItem(IStationary i)
        {
            pensets.Add((Penset)i);
        }
        public void Fetch()
        {
            Console.WriteLine("The list of Pensets are");
            Console.WriteLine("Count: " + pensets.Count);
            foreach (Penset ps in pensets)
            {
                Console.WriteLine($"Pen Name : {ps.PenName}\t Pen Price : {ps.Rate}\t Pen Quantity : {ps.AvailableQuantity}");
            }


        }
        public void RemoveItem(IStationary i)
        {
            pensets.Remove((Penset)i);
        }
        public int CalculateBill()
        {
            return AvailableQuantity * Rate;
        }
    }
}
