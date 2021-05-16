using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_q3
{
    public class Car
    {
        public string CarMake;
        public string CarModel;
        public int Year;
        public double SalePrice;

        public Car(string carmake, string carmodel, int year, double saleprice)
        {
            this.CarMake = carmake;
            this.CarModel = carmodel;
            this.Year = year;
            this.SalePrice = saleprice;
        }

    }
}
