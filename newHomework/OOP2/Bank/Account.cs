using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        public string customer;
        public decimal balance;
        public int interestRate;
        public int monts { get; set; }
        public Account(string customer, decimal balance, int interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }
         
        public decimal Balance
        {
            get { return this.balance; }
            set {this.balance=value; }
        }
        public int InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }
        public string Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public virtual void MakeDeposit(decimal money)
        {
        }
        public virtual void Drow(decimal money)
        {
        }
        public virtual decimal CalculateInterest()
        {
            return monts * this.interestRate;
        }
    }
}
