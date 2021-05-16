using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IBankAccount
    {

        double GetBalance();
        void deposit(double amount);
        bool Withdraw(double amount);
        bool Transfer(IBankAccount toAccount, double amount);
        BankAccountTypeEnum AccountType { get; set; }
        //BankAccountTypeEnum AccountType { get; set; }
    }
    public enum BankAccountTypeEnum
    {
        Current = 1,
        Saving = 2
    }

}