using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(args[0]);

            Console.WriteLine("enter the numbers");


            switch(num)
            {
                case 1:
                   
                    Console.WriteLine("1 found");
                    break;
                case 2:
                    Console.WriteLine("2 found");
                    break;
                case 3:
                    Console.WriteLine("3 found");
                    break;
                case 4:
                    Console.WriteLine("4 found");
                    break;
                case 5:
                    Console.WriteLine("5 found");
                    break;
                default:
                    Console.WriteLine("not found");
                    break;
            }
                    Console.WriteLine("your numbers", num);

            Console.ReadLine();


            



        }

    }
}
