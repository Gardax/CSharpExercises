using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static decimal reverseNumber(decimal num)
        {
            string number = num.ToString();
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            number = new string(array);
            return decimal.Parse(number);
        }
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(reverseNumber(number));
        }
    }
}
