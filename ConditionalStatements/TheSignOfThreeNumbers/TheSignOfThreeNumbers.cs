using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSignOfThreeNumbers
{
    class TheSignOfThreeNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a >= 0 && b >= 0 && c >= 0)
            {
                Console.WriteLine("The sign is +");
            }
            else if (a < 0 && b < 0 && c >= 0)
            {
                Console.WriteLine("The sign is +");
            }
            else if (a >= 0 && b < 0 && c < 0)
            {
                Console.WriteLine("The sign is +");
            }
            else if (a < 0 && b >= 0 && c < 0)
            {
                Console.WriteLine("The sign is +");
            }
            else
            {
                Console.WriteLine("The sign is -");
            }
        }
    }
}
