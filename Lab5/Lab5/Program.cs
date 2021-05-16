using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI icici1 = new ICICI();
            icici1.AccountType = BankAccountTypeEnum.Saving;
            icici1.deposit(50000);
            ICICI icici2 = new ICICI();
            icici2.AccountType = BankAccountTypeEnum.Current;
            icici2.deposit(20000);
            Console.WriteLine("Balance" + icici1.GetBalance());
            Console.WriteLine("Balance" + icici2.GetBalance());
            icici1.Transfer(icici2, 5000);
            Console.WriteLine("Balance" + icici2.GetBalance());

           
            HSBC hsbc1 = new HSBC();
            hsbc1.AccountType = BankAccountTypeEnum.Saving;
            hsbc1.deposit(50000);
            HSBC hsbc2 = new HSBC();
            hsbc2.AccountType = BankAccountTypeEnum.Current;
            hsbc2.deposit(20000);
            Console.WriteLine("Balance" + hsbc1.GetBalance());
            Console.WriteLine("Balance" + hsbc2.GetBalance());
            icici1.Transfer(hsbc2, 5000);
            Console.WriteLine("Balance" + icici2.GetBalance());
            Console.ReadLine();


        }
    }
}
