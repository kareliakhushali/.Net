﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace INotifyPropertyChangeDemo
{
   internal class Program
    {
        private static void Product_PropertyChanged
            (object sender,PropertyChangedEventArgs e)
        {
            Product prod = sender as Product;
            Console.WriteLine($"--------Note:{e.PropertyName} of" + $"Product ID {prod.Id} was changed");

        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(1,100){ProductName = "First Product"},
                 new Product(2,50){ProductName = "Second Product"},
                  new Product(3,100){ProductName = "Third Product"},
                   new Product(4,6500){ProductName = "Fourth Product"},
                    new Product(5,3550){ProductName = "Fifth Product"},

            };
            foreach(Product prod in products)
            {
                Console.WriteLine("{0,-10}{1,-20}{2,15}{3,10}", prod.Id, prod.ProductName,prod.Qty,prod.Rate);
            }
            foreach(Product prod in products)
            {
                prod.PropertyChanged += Product_PropertyChanged; 
            }
            //change qty of first product
            products[0].ChangeQty(120);
            //change rate of third product
            products[2].ChangeQty(33);
            Console.WriteLine();
            products[2].ProductName = "Soap";
            foreach(Product prod in products)
            {
                Console.WriteLine("{0,-10}{1,-20}{2,10}{3,10}", prod.Id, prod.ProductName, prod.Qty, prod.Rate);
            }
            Console.ReadKey();



        }
    }
}
