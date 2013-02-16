using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            //A bank account has a holder name (first name, middle name and last name), 
            //available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account.
            //Declare the variables needed to keep the information for a single bank account using the appropriate data types 
            //and descriptive names.
            string firstName = "George";
            string middleName = "Pavlinov";
            string lastName = "Georgiev";
            decimal amountOfMoney = 4000.52m;
            string bankName = "Banka DSK";
            string IBAN = "BG60BPBI79421043858201";
            string BIC = " BPBIBGSF";
            string[] cardNumbers = new string[3];
            cardNumbers[0] = "321332131-3213";
            cardNumbers[1] = "321332131-3213";
            cardNumbers[2] = "321332131-3213";
        }
    }
}
