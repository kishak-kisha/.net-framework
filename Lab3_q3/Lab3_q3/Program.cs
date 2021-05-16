using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_q3
{
    class Program
    {
        static void Main(string[] args)
        {
            CarInfo car = new CarInfo();
            string ans = "y";
            Console.WriteLine("********************** Welcome *******************************");
            do
            {
                Console.WriteLine("1.Add a New Car.");
                Console.WriteLine("2.Modify Details Of Car.");
                Console.WriteLine("3.Search For a Car.");
                Console.WriteLine("4.List Cars.");
                Console.WriteLine("5.Delete Car.");
                Console.WriteLine("6.Quit.");
                Console.Write("Enter Your Choice :- ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        car.AddCar();
                        break;
                    case 2:
                        car.ModifyCar();
                        break;
                    case 3:
                        car.SearchCar();
                        break;
                    case 4:
                        car.ListCars();
                        break;
                    case 5:
                        car.DeleteCar();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("Do you Wish To Continue :-");
                ans = Console.ReadLine();
            } while (ans == "y" || ans == "Y");
        }
    }
}
