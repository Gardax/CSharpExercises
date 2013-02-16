using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            int binaryNum = int.Parse(Console.ReadLine());
            int j = 0, number=0, multiplayer=1;
            while (binaryNum > 0)
            {
                multiplayer = 1;
                for (int i = 0; i < j; i++)
                {
                    multiplayer *= 2;
                }
                number += binaryNum % 10 * multiplayer;
                binaryNum /= 10;
                j++;
            }
            Console.WriteLine(number);
        }
    }
}
