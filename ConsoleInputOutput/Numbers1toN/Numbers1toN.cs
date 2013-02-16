using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers1toN
{
    class Numbers1toN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
