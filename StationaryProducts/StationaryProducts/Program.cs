using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating instances of three classes
            var Bookset = new Bookset();
            var Notebookset = new Notebookset();
            var Penset = new Penset();
            int choice;
            do
            {
                Console.WriteLine("\n===========Stationary Store=========");
                Console.WriteLine("\n1 Insert Bookset");
                Console.WriteLine("2. Display Bookset");
                Console.WriteLine("3. Insert NoteBookset");
                Console.WriteLine("4.Display NoteBookset");
                Console.WriteLine("5.Insert Penset");
                Console.WriteLine("6.Display Penset");
                Console.WriteLine("Enter your choice:- ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many booksets you want to add? : ");
                        int countbook = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= countbook; i++)
                        {
                            Console.WriteLine("Enter Name:- ");
                            string pName = Console.ReadLine();
                            Console.WriteLine("Enter Price:- ");
                            int pRate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Quantity:- ");
                            int pQuantity = Convert.ToInt32(Console.ReadLine());
                            Bookset book = new Bookset
                            {
                                Bookname = pName,
                                Rate = pRate,
                                AvailableQuantity = pQuantity,

                            };
                            Bookset.AddItem(book);
                            int discountTotal = book.DiscountTotal();
                            Console.WriteLine($"Discounted Total: {discountTotal}");
                            int calculatebill = book.CalculateBill();
                            Console.WriteLine($"Total Bill :{ calculatebill}");
                            /*  Bookset.DiscountTotal();*/
                        }
                        break;
                    case 2:
                        Bookset.Fetch();
                        break;
                    case 3:
                        Console.WriteLine("How many notebooksets you want to add?  ");
                        int countnotebook = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= countnotebook; i++)
                        {
                            Console.WriteLine("Enter Name:- ");
                            string nName = Console.ReadLine();
                            Console.WriteLine("Enter Price:- ");
                            int nRate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the quantity:-");
                            int nQuantity = Convert.ToInt32(Console.ReadLine());
                            //creating  a new instance of th4e notebook class 
                            // allows to set the initial values of an object's properties without explicitly calling its constructor.
                            Notebookset notebook = new Notebookset
                            {
                                NoteBookName = nName,
                                NRate = nRate,
                                NAvailableQuantity = nQuantity,

                            };
                          Notebookset.AddItem(notebook);
                            int discountTotal = notebook.DiscountTotal();
                            Console.WriteLine($"Discounted Total: {discountTotal}");
                              Notebookset.DiscountTotal();
                            int calculatebill = notebook.CalculateBill();
                            Console.WriteLine($"Total Bill :{ calculatebill}");
                        }
                        break;
                    case 4:
                        Notebookset.Fetch();
                        break;
                    case 5:
                        Console.WriteLine("How many pensets you want to add? :");
                        int countpenset = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= countpenset; i++)
                        {
                            Console.WriteLine("Enter Name:- ");
                            string pName = Console.ReadLine();
                            Console.WriteLine("Enter Price:- ");
                            int pRate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the quantity:-");
                            int pQuantity = Convert.ToInt32(Console.ReadLine());
                            Penset penset = new Penset
                            {
                                PenName = pName,
                                Rate = pRate,
                                AvailableQuantity = pQuantity,

                            };
                            Penset.AddItem(penset);
                            int calculatebill = penset.CalculateBill();
                            Console.WriteLine($"Total Bill :{ calculatebill}");

                        }

                        break;
                    case 6:
                        Penset.Fetch();
                        break;
                    



                }
            }
            while (choice != 6);
            //textbook.Discount();
            //Bookset b = new Bookset();
           // b.DiscountTotal();
            Console.ReadKey();
        }
    }
}
