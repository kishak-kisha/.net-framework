using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
           double num1 = 0, num2 = 0, answer = 0;
            string operand;
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a operand <+,-,*,/:");
            operand = Console.ReadLine();
            Console.Write("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
            }
            Console.WriteLine("Your answer is: {0}{1}{2} = {3}", num1, operand, num2, answer);
        }
    }
}
