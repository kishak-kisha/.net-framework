using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird b = new Bird("Eagle", double.Parse("200"));
            b.fly();
            b.fly(double.Parse("300"));
            Bird b2 = new Bird();
            b2.fly();

        }
    }
}
