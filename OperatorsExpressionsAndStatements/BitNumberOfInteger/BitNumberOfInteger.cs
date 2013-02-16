using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitNumberOfInteger
{
    class BitNumberOfInteger
    {
        static void Main(string[] args)
        {
            int b = 2;
            int i = 5;
            int mask = 1 << b;
            int vAndMask = i & mask;
            int bit = vAndMask >> b;
            Console.WriteLine("i=" + i + "; b=" + b + " -> value=" + bit);   
        }
    }
}
