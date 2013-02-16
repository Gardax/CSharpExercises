using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes 
    {

        static void Main(string[] args)
        {
            long n = 10000000;
            bool[] e = new bool[n];
            for (int i = 2; i < n; i++)
            {
                e[i] = true;
            }
            for (int j = 2; j < n; j++)
            {
                if (e[j])
                {
                    for (long p = 2; (p * j) < n; p++)
                    {
                        e[p * j] = false;
                    }
                }
            }
            for (int i = 2; i < n; i++)
            {
                if (e[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
