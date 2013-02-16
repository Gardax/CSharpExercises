using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int to = n;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= to; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
                to++;
            }
        }
    }
}
