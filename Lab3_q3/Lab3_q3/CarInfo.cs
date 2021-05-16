using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_q3
{
    public class CarInfo
    {
        static int count = 0;
        Car[] catalog = new Car[10];

        public void AddCar()
        {
            Console.WriteLine("Enter Car Make :-");
            string carmake = Console.ReadLine();
            Console.WriteLine("Enter Car Model :-");
            string carmodel = Console.ReadLine();
            Console.WriteLine("Enter Year Of Release :-");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("EnterSalePrice :-");
            double saleprice = double.Parse(Console.ReadLine());
            catalog[count] = new Car(carmake, carmodel, year, saleprice);
            count++;
        }
        public void ListCars()
        {
            if (count > 0)
            {
                Console.WriteLine("CarMake CarModel Year SalePrice");
                foreach (Car c in catalog)
                {
                    if (c != null)
                        Console.Write(c.CarMake + "\t" + c.CarModel + "\t" + c.Year + "\t" + c.SalePrice + "\n");
                }
            }
            else
                Console.WriteLine("Car Catalog Is Empty..!!");
        }

        public void SearchCar()
        {
            if (count > 0)
            {
                int temp = 0;
                Console.Write("Which Car Make You Want To Search \n Enter Car Make : ");
                string search = Console.ReadLine();
                foreach (Car c in catalog)
                {
                    if (c != null)
                    {
                        if (c.CarMake.ToLower() == search.ToLower())
                        {
                            Console.Write(c.CarMake + "\t" + c.CarModel + "\t" + c.Year + "\t" + c.SalePrice + "\n");
                            temp++;
                        }

                    }
                }
                if (temp == 0)
                {
                    Console.WriteLine("No Results Were Found..!");
                }

            }
            else
                Console.WriteLine("Can't Perform Search Oparetion\nBecause Car Catalog Is Empty..!!");

        }
        public void DeleteCar()
        {
            if (count > 0)
            {
                ListCars();
                int temp = 0;
                int flag = 0;
                Console.WriteLine();
                Console.Write("Which Car U Want To Delete\nEnter Car Model name :- ");
                string answer = Console.ReadLine();
                foreach (Car c in catalog)
                {
                    if (c != null)
                    {
                        if (c.CarModel.ToLower() == answer.ToLower())
                        {
                            temp = Array.IndexOf(catalog, c);
                            catalog[temp] = null;
                            flag++;
                        }
                    }
                }
                if (flag == 0)
                    Console.WriteLine("You Entered an incorrect value");
                else
                    Console.WriteLine("Deleted Successfully..");
            }
            else
                Console.WriteLine("Can't Perform Delete Operation\nBecause Car Catalog is empty");
        }
        public void ModifyCar()
        {
            if (count > 0)
            {
                ListCars();
                int temp = 0;
                int flag = 0;
                Console.WriteLine();
                Console.Write("Which Car You Want To Modify\nEnter Car Model name :- ");
                string answer = Console.ReadLine();
                foreach (Car c in catalog)
                {
                    if (c != null)
                    {
                        if (c.CarModel.ToLower() == answer.ToLower())
                        {
                            temp = Array.IndexOf(catalog, c);
                            Console.WriteLine("Enter New Car Make");
                            string carmake = Console.ReadLine();
                            Console.WriteLine("Ente New Car Model Name");
                            string carmodel = Console.ReadLine();
                            Console.WriteLine("Enter New Year Of Release :-");
                            int year = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter New SalePrice :-");
                            double saleprice = double.Parse(Console.ReadLine());
                            catalog[temp] = new Car(carmake, carmodel, year, saleprice);
                        }
                    }
                }
                if (flag == 0)
                    Console.WriteLine("You Entered an incorrect value");
                else
                    Console.WriteLine("Updated Data Successfully..");
            }
            else
                Console.WriteLine("Can't Perform Update Operation\nBecause Car Catalog is empty");
        }
    }
}

