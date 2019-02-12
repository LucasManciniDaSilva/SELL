using System;
namespace Sell.Entities
{
    public class Products
    {
        //Defined the variables
        public String Name { get; set; }
        public double Price { get; set; }

        //Created a constructor without arguments
        public Products()
        {
        }

        //Created a constructor with arguments
        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //Created the method to return a PriceTag of the product
        public virtual void PriceTag()
        {
            Console.WriteLine(Name + " $" + Price);
        }
    }
}
