using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("enter the Customer id:");
            customer.CustomerId1 = Console.ReadLine();
            Console.WriteLine("enter the Customer Name:");
            customer.CustomerName1= Console.ReadLine();
            Console.WriteLine("enter the address:");
            customer.Address1 = Console.ReadLine();
            Console.WriteLine("enter the phone:");
            customer.Phone1 = Console.ReadLine();
            Console.WriteLine("enter the city:");
            customer.City1 = Console.ReadLine();
            try
            {
                Console.WriteLine("enter credit list:");
                customer.CreditLimit1 = int.Parse(Console.ReadLine());
                if (customer.CreditLimit1 >= 50000)
                {
                    throw new Exception();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("credit limit ");
            }
        }
    }
}
