using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask
{
    class Bookset
    {
        private string name;
        private double price;
        private int quantity;

        public Bookset(string v1, int v2)
        {
        }

        public Bookset(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }
        public int CalculateBill()
        {
            int discount = quantity > 10 ? 15 : 10;
            return (int)(quantity * price * (100 - discount) / 100.0);
        }

        public int GetQuantity()
        {
            return quantity;
        }
    }
}
   