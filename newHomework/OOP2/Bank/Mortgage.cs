using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Mortgage:Account
    {
        public int mortgagePeriod;
         public Mortgage(string customer, decimal balance, int interestRate,int mortgagePeriod)
          : base(customer, balance, interestRate)
            {
              this.mortgagePeriod = mortgagePeriod;
            }
        public override void MakeDeposit(decimal money)
        {
            this.Balance += money;
        }
        public override decimal CalculateInterest()
        {
            if (this.mortgagePeriod <= 6 && customer=="individuals")
            {
                return 0;
            }
            else if (this.mortgagePeriod <= 12 && customer=="companies")
            {
                return this.mortgagePeriod * this.InterestRate/2;
            }
            else if (this.mortgagePeriod >= 12 && customer == "companies")
            {
                decimal interest = 12 * this.InterestRate / 2;
                interest += (this.mortgagePeriod - 12) * this.InterestRate;
                return interest;

            }
            else 
            {
                return this.mortgagePeriod * this.InterestRate;
            }

        }
    }
}
