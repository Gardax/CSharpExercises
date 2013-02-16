using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devideBy7And5
{
    class DevideBy7And5
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 7 == 0 && number % 5 == 0) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
