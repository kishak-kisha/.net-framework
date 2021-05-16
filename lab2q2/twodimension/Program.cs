using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twodimension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 6];
            arr[0, 5] = 10;
            arr[1, 4] = 20;
            arr[2, 3] = 30;
            arr[3, 2] = 40;
            arr[4, 1] = 50;
            for(int i =0; i<5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
            

        }
    }
}
