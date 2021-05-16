using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_q2
{
    public class Bird
    {
        public string name;
        public double maxheight;
        private double AtHeight;

        public Bird()
        {
            this.name = "Mountain Eagle";
            this.maxheight = 500;
        }

       public  Bird(string birdname, double maxheight)
        {
            this.name = "Another bird";
            this.maxheight = 0;
 }
        public void fly()
        {
            Console.WriteLine("{0} is flying at altitude{1}", this.name, this.maxheight);
        }
        public void fly(double max_height)
        {
            if (AtHeight <= this.maxheight)
            {
                Console.WriteLine(this.name + "flying at" + AtHeight.ToString());
            }
            else
            {
                Console.WriteLine(this.name + "cannot fly at this height");
            }
        }

        }
    }

