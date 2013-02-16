using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FloatingPointNumbers
{
    class FloatingPointNumbers
    {
        static void Main(string[] args)
        {
            //Write a program that safely compares floating-point numbers with precision of 0.000001.
            //Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
            float a = 5.3f;
            float b = 6.01f;
            if (a > b) Console.WriteLine("True");
            else Console.WriteLine("False");
            float c = 5.00000001f;
            float d = 5.00000003f;
            if (c == d) Console.WriteLine("True");
            else Console.WriteLine("False");

        }
    }
}
