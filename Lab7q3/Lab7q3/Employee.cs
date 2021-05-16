using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7q3
{
    public class Employee
    {
        public Employee(int employeeNumber, string employeeName, double basicSalary, double pF)
        {
            EmployeeNumber = employeeNumber;
            EmployeeName = employeeName;
            BasicSalary = basicSalary;
            PF = pF;
        }

        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public double BasicSalary { get; set; }
        public double PF { get; set; }


    }
}
