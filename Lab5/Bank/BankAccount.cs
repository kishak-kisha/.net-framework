using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankAccount : IBankAccount
    {
        protected double balance;

        public abstract double GetBalance();

        public void deposit(double amount)
        {
            balance = balance + amount;
        }
        public virtual bool Withdraw(double amount)
        {
            return true;
        }

        public virtual bool Transfer(IBankAccount bankAccount, double amount)
        {
            return true;
        }
        public BankAccountTypeEnum AccountType
        {
            get; set;
        }
    }
}

