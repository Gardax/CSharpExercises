using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Loan:Account
    {
        public int loanPeriod;
         public Loan(string customer, decimal balance, int interestRate,int loanPeriod)
          : base(customer, balance, interestRate)
            {
              this.loanPeriod = loanPeriod;
            }
        public override void MakeDeposit(decimal money)
        {
            this.Balance += money;
        }
        public override decimal CalculateInterest()
        {
            if (this.loanPeriod <= 3 && customer=="individuals")
            {
                return 0;
            }
            else if (this.loanPeriod <= 2 && customer=="companies")
            {
                return 0;
            }
            else
            {
                return this.loanPeriod * this.InterestRate;
            }

        }
    }
}
