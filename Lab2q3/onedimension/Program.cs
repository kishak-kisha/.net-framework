using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onedimension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] city = new string[4];
            city[0] = "chennai";
            city[1] = "bangalore";
            city[2] = "mumbai";
            city[3] = "delhi";
            foreach(string item in city)
            {
                Console.WriteLine(item);
            }
        }
    }
}
