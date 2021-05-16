using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1;
namespace Lab1_q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            SetDetails(a);
            Console.WriteLine();
            GetDetails(a);
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter Employee Details");
            Console.WriteLine();
            Employee[] e = new Employee[10];
            for (int i = 0; i < 10; i++)
            {
                e[i] = new Employee();
                Set2Details(e[i]);
            }
            Console.WriteLine("Employees Details ");
            for (int i = 0; i < 10; i++)
            {
                Get2Details(e[i]);
            }
            Console.ReadLine();
        }
        static void SetDetails(Employee e1)
        {
            Console.Write("Enter Id Of Employee : ");
            e1.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name Of Employee : ");
            e1.EmployeeName = Console.ReadLine();
            Console.Write("Enter Address Of Employee : ");
            e1.Address = Console.ReadLine();
            Console.Write("Enter City Of Employee : ");
            e1.City = Console.ReadLine();
            Console.Write("Enter Department Of Employee : ");
            e1.Department = Console.ReadLine();
            Console.Write("Enter Salary Of Employee : ");
            e1.Salary = float.Parse(Console.ReadLine());
        }
        static void GetDetails(Employee e2)
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Employee Id :" + e2.EmployeeId);
            Console.WriteLine("Employee Name  :" + e2.EmployeeName);
            Console.WriteLine("Address : " + e2.Address);
            Console.WriteLine("City : " + e2.City);
            Console.WriteLine("Deapartment :" + e2.Department);
            Console.WriteLine("Salary : " + e2.Salary);
        }
        static void Set2Details(Employee e)
        {
            Console.Write("Enter Name Of Employee : ");
            e.EmployeeName = Console.ReadLine();
            Console.Write("Enter Salary Of Employee : ");
            e.Salary = float.Parse(Console.ReadLine());
        }
        static void Get2Details(Employee e)
        {
            Console.WriteLine(e.EmployeeName + " : " + e.Salary);
        }
    }
}
