
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4q1apr
{
    class Employee

    {
        internal int employeeId;
        internal string employeeName;
        

        public int empid { get; set; }
                
        public string empname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public double salary { get; set; }
        public virtual double GetSalary()
        {
            return salary;
        }

        public Employee(int empid, string empname, string address, string city, double salary)
        {
            this.empid = empid;
            this.empname = empname;
            this.address = address;
            this.city = city;
            this.salary = salary;
        }

    }
}
