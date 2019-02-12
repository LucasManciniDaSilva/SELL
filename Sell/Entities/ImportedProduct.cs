using System;
namespace Sell.Entities
{
    public class ImportedProduct : Products
    {
        //Defined the variable of this class
        public double CustomsFee { get; set; }


        //Created a constructor without arguments
        public ImportedProduct()
        {
        }

        //Created a constructor with arguments, inherit elements of class Products
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.CustomsFee = customsFee;
        }

        //Created a method to calculate the total price of an Imported Product.
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        //Added a new function for the method PriceTag when the product is imported
        public override void PriceTag()
        {
             
            Console.WriteLine(Name + " $" + TotalPrice() + "(CustomsFee: $" + CustomsFee + ")");

        }

    }
}
