using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Q4
{
    class ProductDemo
    {
        static void Main(string[] args)
        {
            object productId;
            object productName;
            object price;
            object quantity;
            object amtPayable;

            Console.WriteLine("enter your product id:");
            productId = Console.ReadLine();
            int ProductId = Convert.ToInt32(productId);

            Console.WriteLine("enter your product name:");
            productName = Console.ReadLine();
            string ProductName = (string)productName;

            Console.WriteLine("enter your price:");
            price = Console.ReadLine();
            int Price = Convert.ToInt32(price);

            Console.WriteLine("enter your quantity:");
            quantity = Console.ReadLine();
            int Quantity = Convert.ToInt32(quantity);

            

            Console.WriteLine("product id:" +ProductId);
            Console.WriteLine("product name:" + ProductName);
            Console.WriteLine("price:" + Price);
            Console.WriteLine("quantity:" + Quantity);
            Console.WriteLine("amount payable:" + Price * Quantity);

            Console.ReadLine();














        }
    }
}
