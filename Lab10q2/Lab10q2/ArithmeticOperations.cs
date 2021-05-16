using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab10q2.ArithmeticOperations;


namespace Lab10q2
{
    public class ArithmeticOperations
    {
       
            public delegate void Arithmetic(double x, double y);

            public static void PerformArithmeticOperation(Arithmetic d, double i, double j)
            {
                d(i, j);
            }
            public static void Add(double num1, double num2)
            {
                Console.WriteLine(num1 + num2);
            }
            public static void Multiply(double num1, double num2)
            {
                Console.WriteLine(num1 * num2);
            }
            public static void Divide(double num1, double num2)
            {
                Console.WriteLine(num1 / num2);
            }
            public static void subtract(double num1, double num2)
            {
                Console.WriteLine(num1 - num2);
            }
            public static void Maximum(double num1, double num2)
            {
                Console.WriteLine(Math.Max(num1, num2));
            }

        }
        public class DelegatePar
        {
            static void Main(string[] args)
            {
                ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
                Console.Write("Enter Number1:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Number2:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Multiply");
                Console.WriteLine("3.Divide");
                Console.WriteLine("4.Subtract");
                Console.WriteLine("5.Max");
                Console.Write("Enter your Choice:");
                int ch = (int.Parse)(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            Arithmetic arithmetic = ArithmeticOperations.Add;
                            PerformArithmeticOperation(arithmetic, num1, num2);
                        }
                        break;
                    case 2:
                        {
                            Arithmetic arithmetic = ArithmeticOperations.Multiply;
                            PerformArithmeticOperation(arithmetic, num1, num2);
                        }
                        break;
                    case 3:
                        {
                            Arithmetic arithmetic = ArithmeticOperations.Divide;
                            PerformArithmeticOperation(arithmetic, num1, num2);
                        }
                        break;
                    case 4:
                        {
                            Arithmetic arithmetic = ArithmeticOperations.subtract;
                            PerformArithmeticOperation(arithmetic, num1, num2);
                        }
                        break;
                    case 5:
                        {
                            Arithmetic arithmetic = ArithmeticOperations.Maximum;
                            PerformArithmeticOperation(arithmetic, num1, num2);
                        }
                        break;
                }

                Console.Read();
            }

        }


    }


