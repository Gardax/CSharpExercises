using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsTheThirdDigit7
{
    class IsTheThirdDigit7
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number %= 1000;
            number /= 100;
            if (number == 7) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}
