using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4q1apr
{
    class Program
    {

        static int choice = 0;
        static Employee[] employee = new Employee[2];
       public static void Main(string[] args)
        {
            string ans = "y";
            do
            {
                Console.WriteLine("1.Enter permanent employee data");
                Console.WriteLine("2.Enter contract employee data");
                Console.Write("enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Employee employee = null;
                switch (choice)
                {
                    case 1:
                        employee = new PermanentEmployee();
                        break;
                    case 2:
                        employee = new ContractEmployee();
                        break;

                }
                GetEmployeeDetails(employee);
                DisplayEmployee(employee);
                Console.ReadLine();
            }
            
            static void GetEmployeeDetails(Employee employee)
            {
                Console.Write("Enter Employee ID:");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name:");
                string name = Console.ReadLine();
                Console.Write("Enter Address:");
                string address = Console.ReadLine();
                Console.Write("Enter City:");
                string city = Console.ReadLine();
                Console.Write("Enter Salary:");
                double salary = Convert.ToDouble(Console.ReadLine());
                employee.employeeId = sid;
                employee.employeeName = name;
                employee.city = city;
                employee.address = address;
                employee.salary = salary;
                if (choice == 1)
                {
                    PermanentEmployee permanentEmployee = (PermanentEmployee)employee;
                    Console.Write("Enter Provident Fund:");
                    double pf = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter No of Leaves:");
                    int noofleaves = Convert.ToInt32(Console.ReadLine());
                    permanentEmployee.providentFund = pf;
                    permanentEmployee.noOfLeaves = noofleaves;
                }
                else if (choice == 2)
                {
                    ContractEmployee ce = (ContractEmployee)s;
                    Console.Write("Enter Perks:");
                    double perks = Convert.ToDouble(Console.ReadLine());
                    ce.Perks = perks;

                }
            }
            static void DisplayEmployee(Employee employee)
            {
                Console.WriteLine("Employee Name \t Salary");

                Console.Write(s.employeeName + "\t\t");
                Console.Write(s.GetSalary());
                Console.WriteLine();

            }
        }
    }
}
