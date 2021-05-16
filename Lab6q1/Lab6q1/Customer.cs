using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6q1
{
    class Customer
    {
        private string CustomerId;
        private string CustomerName;
        private string Address;
        private string City;
        private string Phone;
        private int CreditLimit;

        public string CustomerId1 { get => CustomerId; set => CustomerId = value; }
        public string CustomerName1 { get => CustomerName; set => CustomerName = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string City1 { get => City; set => City = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public int CreditLimit1 { get => CreditLimit; set => CreditLimit = value; }

       
        public Customer(string customerId, string customerName, string address, string city, string phone, int creditLimit)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Address = address;
            City = city;
            Phone = phone;
            CreditLimit = creditLimit;
        }

        public Customer()
        {
            this.CustomerId1 = CustomerId;
            this.CustomerName1 = CustomerName1;
            this.Address1 = Address1;
            this.City1 = City1;
            this.Phone1 = Phone1;
            this.CreditLimit1 = CreditLimit1;

        }
    }
}
