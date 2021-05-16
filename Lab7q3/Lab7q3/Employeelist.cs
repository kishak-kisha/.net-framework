using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7q3
{
    public class EmployeeList
    {
        List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee emploee)
        {
            employees.Add(emploee);
        }
        public List<Employee> ViewAll()
        {
            return employees;
        }
        public bool DeleteRecords(int enumber)
        {
            Employee employee = null;
            foreach (Employee e in employees)
            {
                if (e.EmployeeNumber == enumber)
                {
                    employee = e;
                    break;
                }
            }
            if (employee != null)
            {
                employees.Remove(employee);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Employee SearchRecords(int enumber)
        {
            Employee employee = null;
            foreach (Employee e in employees)
            {
                if (e.EmployeeNumber == enumber)
                {
                    employee = e;
                    break;
                }
            }
            if (employee != null)
            {
                employees.Remove(employee);
                return employee;
            }
            else
            {
                return null;
            }
        }

    }
}