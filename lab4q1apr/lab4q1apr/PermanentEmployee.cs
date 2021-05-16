using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4q1apr
{
    class PermanentEmployee : Employee
    {
        public int NoOfLeaves;
            public double ProvidentFund;
        internal double providentFund;
        internal int noOfLeaves;

        public override double GetSalary()
        {
            return base.GetSalary() - ProvidentFund;
        }
    }
}
