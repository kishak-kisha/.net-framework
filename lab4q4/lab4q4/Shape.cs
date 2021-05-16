using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4q4
{
    public class Shape
    {
        public virtual void Whoami()
        {
            Console.WriteLine("I am Shape");
        }
        public class Triangle : Shape
        {
            public override void Whoami()
            {
                Console.WriteLine("i am Triangle");

            }
            public class Circle : Shape
            {
                public override void Whoami()
                {
                    Console.WriteLine("i am circle");

                }

            }
        }
        class Program
        {


            static void Main(string[] args)
            {
                Shape s1= new Shape();
                Shape s2 = new Triangle();
                Shape s3 = new Circle();
                s1.Whoami();
                s2.Whoami();
                s3.Whoami();


            }
        }

    }
}