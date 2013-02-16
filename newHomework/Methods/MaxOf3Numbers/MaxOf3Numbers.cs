using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOf3Numbers
{
    class MaxOf3Numbers
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(GetMax(number1,number2),GetMax(number2,number3)));
        }
    }
}
