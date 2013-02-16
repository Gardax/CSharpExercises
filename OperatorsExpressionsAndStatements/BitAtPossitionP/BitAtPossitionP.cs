using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitAtPossitionP
{
    class BitAtPossitionP
    {
        static void Main(string[] args)
        {
            int p = 1;
            int v = 5;
            int mask = 1 << p;
            int vAndMask = v & mask;
            int bit = vAndMask >> p;
            if (bit==1)
            {
                Console.WriteLine("v=" + v + "; p=" + p + " -> true");
            }
            else
            {
                Console.WriteLine("v=" + v + "; p=" + p + " -> false");
            }
        }
    }
}
