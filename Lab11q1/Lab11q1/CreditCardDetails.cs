using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11q1
{
    class Publisher
        {
        public delegate void EventDelegate();
        public event EventDelegate myevent;
        public void FireEvent()
        {
            if (myevent != null)
            {
                myevent(); 
              
            }
        }
    }
    class Subscriber
    {
        public void Task()
        {
            Console.WriteLine("amount is credited");
        }
    }

    class CreditCardDetails :CreditCard
    {
        public double GetBalance()
        {
            return BalanceAmount;
        }
        public double GetCreditLimit()
        {
            return CreditLimit;
        }
        public bool MakePayamenrt(double amount)
        {
            BalanceAmount += amount;
            return true;
        }

    }
}
