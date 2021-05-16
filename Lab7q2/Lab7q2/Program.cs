using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab7q2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDetails productDetails = new ProductDetails();
            do
            {
                Console.WriteLine("1.Add New Product");
                Console.WriteLine("2.Deleting Currently Searched Product");
                Console.WriteLine("3.Search Product");
                Console.WriteLine("4.Save the New Product");
                Console.WriteLine("Enter your Choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Product p = GetDetails();
                            productDetails.AddProduct(p);

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Produt Id");
                            int Id = int.Parse(Console.ReadLine());
                            if (productDetails.DeleteProduct(Id))
                            {
                                Console.WriteLine("Product Removed.");
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter Product No");
                            string pno = Console.ReadLine();
                            Product product = productDetails.GetProduct(pno);
                            if (product != null)
                            {
                                Console.WriteLine("Rate: " + product.Name);
                                Console.WriteLine("Rate: " + product.Rate);
                                Console.WriteLine("Availability: " + product.Stock);
                            }
                            else
                                Console.WriteLine("Product Not Exist");
                        }
                        break;
                    case 4:
                        ArrayList products = productDetails.GetProducts();
                        foreach (Product p in products)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", p.ProductNo, p.Name, p.Rate, p.Stock);
                        }
                        int a = productDetails.SortedOrder();
                        if (a)
                        {
                            ArrayList products1 = productDetails.GetProducts();
                            foreach (Product p in products1)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", p.ProductNo, p.Name, p.Rate, p.Stock);
                            }
                        }
                        break;


                }
            } while (true);
        }

        private static Product GetDetails()
        {
            Product product = new Product();
            Console.WriteLine("Enter Product Details");
            Console.WriteLine("Enter Id");
            product.ProductNo= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter Rate");
            product.Rate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stock");
            product.Stock = int.Parse(Console.ReadLine());
            return product;

        }
    }
}
