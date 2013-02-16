using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsPrime
{
    class IsPrime
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            if ((n % 2 != 0 || n == 2) && (n % 3 != 0 || n == 3) && (n % 5 != 0 || n == 5) && (n % 7 != 0 || n == 7) && (n % 11 != 0 || n == 11) && (n % 13 != 0 || n == 13))
            {
                Console.WriteLine("The number is prime");
            }
            else 
            {
                Console.WriteLine("The number is not prime");
            }
        }
    }
}
