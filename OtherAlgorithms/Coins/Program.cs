using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            int coinsByFive = amount / 5;
            amount %= 5;

            int coinsByTwo = amount / 2;
            amount %= 2;

            int coinsByOne = amount;

            Console.WriteLine("You need {0} coins of five, {1} coins of two and {2} coins of one!",
                              coinsByFive, coinsByTwo, coinsByOne);
        }
    }
}
