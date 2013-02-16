using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitAt3Possition
{
    class BitAt3Possition
    {
        static void Main(string[] args)
        {
            int p = 3;
            int n = 35;              
            int mask = 1 << p;       
            int nAndMask = n & mask; 
            int bit = nAndMask >> p; 
            Console.WriteLine(bit);
        }
    }
}
