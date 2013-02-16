using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int number;
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("The {0} is even.", number);
            else Console.WriteLine("The {0} is odd.", number);
        }
    }
}
