using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class HSBC : BankAccount
    {
        public override double GetBalance()
        {
            return balance;
        }
        public override bool Withdraw(double amount)
        {
            double balance = GetBalance();
            if (balance - amount >= 5000)
            {
                Console.WriteLine("Withdrawing");
            }

            return true;
        }
        public override bool Transfer(IBankAccount bankAccount, double amount)
        {
            double balance = bankAccount.GetBalance();

            if (balance - amount >= 5000)
            {
                bankAccount.deposit(amount);

                Console.WriteLine("Transfered");
            }
            return true;
        }


    }
}
