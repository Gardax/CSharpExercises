using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Nfactorial
{
    class Nfactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFact = n;
            for (int i = 1; i < n; i++)
            {
                nFact *= i;
            }
            Console.WriteLine(nFact);
        }
    }
}
