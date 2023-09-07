using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask
{
    class Notebook:IStationary
    {
        private string name;
        private double rate;
        private int quantity;

        public Notebook(string v1, int v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public Notebook(string name, double rate, int quantity)
        {
            this.name = name;
            this.rate = rate;
            this.quantity = quantity;
        }

        public string V1 { get; }
        public int V2 { get; }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return quantity * rate;
        }

        public int GetQuantity()
        {
            return quantity;
        }
        public int CalculateBill()
        {
            int discount = quantity > 10 ? 15 : 10;
            return (int)(quantity * rate * (100 - discount) / 100.0);
        }
    }
}
