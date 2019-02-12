using System;
using Sell.Entities;
using System.Collections.Generic;

namespace Sell
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a list
            List<Products> list = new List<Products>();

            //Created an interaction with the user
            Console.Write("Enter the numbers of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} Data:");
                Console.Write("Common, used or imported? (c/u/i/): ");
                char x = char.Parse(Console.ReadLine());

                //Created a switch case to choose the type of products
                switch (x)
                {
                    case 'c':
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine());
                            list.Add(new Products(name, price));
                            break;
                        }

                    case 'u':
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Manufacture Date (DD/MM/YYYY): ");
                            DateTime data = DateTime.Parse(Console.ReadLine());
                            list.Add(new UsedProduct(name, price, data));
                            break;
                        }

                    case 'i':
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Custom fee: ");
                            double custom = double.Parse(Console.ReadLine());
                            list.Add(new ImportedProduct(name, price, custom));
                            break;
                        }

                    default:
                        {

                            Console.WriteLine("Error, you doesn´t choose an avalible option");
                            break;
                        }

                }


            }
            Console.WriteLine();
            Console.WriteLine("Price tags");

            foreach (Products prod in list)
            {
                prod.PriceTag();

            }

        }
    }
}
