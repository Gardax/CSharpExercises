using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            uint n;
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                Console.WriteLine("binary initial n:");
                Console.WriteLine(Convert.ToString(n, 2));

                n = ((~(7u << 24 | 7u << 3)) & n) | (((n & (7u << 3)) << 21) | ((n & (7u << 24)) >> 21));//Swap bits 3,4,5 with 24,26,26

                Console.WriteLine("binary new n:");
                Console.WriteLine(Convert.ToString(n, 2));
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
