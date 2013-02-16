using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreatestOf5Variables
{
    class GreatestOf5Variables
    {
        static void Main(string[] args)
        {
            int a = 3,b=5,c=1,d=20,e=11;
            Console.WriteLine(Math.Max(Math.Max(Math.Max(e, d), Math.Max(b, c)), a));

        }
    }
}
