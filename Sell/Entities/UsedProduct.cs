using System;
using Sell.Entities;
namespace Sell.Entities
{
    public class UsedProduct : Products
    {
        //Defined the variables
        public DateTime ManufactureDate { get; set; }

        ////Created a constructor without arguments
        public UsedProduct()
        {
        }

        //Created a constructor with arguments, inherit elements of class Products
        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override void PriceTag()
        {
            Console.WriteLine(Name + "(Used) $" + Price + "(Manufacture date :" + ManufactureDate.ToString("dd/MM/yyyy") + ")");
        }
    }
}
