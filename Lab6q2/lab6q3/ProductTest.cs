using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6q3
{
   public  class ProductTest
    {
        static void Main(string[] args)
        {
            ProductMock P1 = new ProductMock();
            P1.GetProductDetails();
            Console.WriteLine();
            if (P1._ProductId > 0 && P1._ProductName != "" && P1._Price > 0)
            {
                P1.DisplayDetails();
                Console.ReadKey();
            }
            else
                Console.ReadKey();

        }

    }
}
