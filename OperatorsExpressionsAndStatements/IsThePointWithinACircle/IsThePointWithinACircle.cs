using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsThePointWithinACircle
{
    class IsThePointWithinACircle
    {
        static void Main(string[] args)
        {
            int x = 3, y = 4;
            if (x < 5 && x > -5 && y < 5 && y > -5)
            {
                Console.WriteLine("The point is in the circle");
            }
            else
            {
                Console.WriteLine("The point is not in the circle");
            }
        }
    }
}
