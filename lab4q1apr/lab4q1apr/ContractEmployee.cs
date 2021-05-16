using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4q1apr
{
    class ContractEmployee : Employee
    {
        public double Perks;
        public override double GetSalary()
        {
            return Perks + base.GetSalary();
        }
    }
}
