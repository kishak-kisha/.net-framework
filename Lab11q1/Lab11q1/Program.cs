using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11q1
{
    class Program 

    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            //Subscribing Methods to event
            publisher.myevent += subscriber.Task;
            CreditCard creditCard = new CreditCard();
            CreditCardDetails creditCardDetails = new CreditCardDetails();
            Console.WriteLine("Enter credit card number:");
            creditCard.CreditCardNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter card holder name:");
            creditCard.CardHolderName = Console.ReadLine();
            Console.WriteLine("Enter amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (creditCardDetails.MakePayamenrt(amount))
            {
                publisher.FireEvent();
            }

            Console.WriteLine("BalanceAmount:" + creditCardDetails.BalanceAmount);
            Console.ReadLine();
        }
    }
}
