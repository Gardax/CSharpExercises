using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralSystems
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int[] binaryNumber = new int[32];
            int number = int.Parse(Console.ReadLine());
            int j = 0;
            while (number > 0)
            {
                binaryNumber[j] = number % 2;
                number /= 2;
                j++;
            }
            for (int i = j-1; i>=0; i--)
            {
                Console.Write(binaryNumber[i]);
            }
            Console.WriteLine();
        }
    }
}
