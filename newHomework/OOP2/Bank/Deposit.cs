using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Deposit:Account
    {
        private int depositPeriod;

      public Deposit(string customer, decimal balance, int interestRate,int depositPeriod)
          : base(customer, balance, interestRate)
      {
          this.depositPeriod = depositPeriod;
      }

      public override void MakeDeposit(decimal money)
      {
          this.balance += money;
      }
      public override void Drow(decimal money)
      {
          if (this.balance > money)
          {
              this.balance -= money;
          }
          else
          {
              throw new Exception("You don't have enought money!");
          }
      }
      public override decimal CalculateInterest()
      {
          if (this.balance<=1000)
          {
              return 0;
          }
          else
          {
              return this.depositPeriod * this.InterestRate;
          }
        
      }
    }
}
