using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6q3
{
    class ProductMock
    {
        public int _ProductId { set; get; }
        public string _ProductName { set; get; }
        public double _Price { set; get; }
        public ProductMock()
        {

        }
        public ProductMock(int ProductId, string ProductName, double Price)
        {
            this._ProductId = ProductId;
            this._ProductName = ProductName;
            this._Price = Price;
        }
        public void GetProductDetails()
        {
            {
                Console.WriteLine("Enter the Product Id");
                _ProductId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Product name");
                _ProductName = Console.ReadLine();
                Console.WriteLine("Enter the Product Price");
                _Price = double.Parse(Console.ReadLine());

                try
                {
                    if (_ProductId <= 0)
                    {
                        throw new DataEntryException("Product ID must be greater than zero");

                    }
                }
                catch (DataEntryException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    if (_ProductName == "")
                    {
                        throw new DataEntryException("Product Name cannot be left blank");
                    }
                }
                catch (DataEntryException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    if (_Price <= 0)
                    {
                        throw new DataEntryException("Price of product must be greater than zero");
                    }
                }
                catch (DataEntryException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"ProductId is {_ProductId}\nProductName is {_ProductName}\nProductPrice is {_Price}");
        }
    }
}
