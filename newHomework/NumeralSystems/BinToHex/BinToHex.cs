using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToHex
{
    class BinToHex
    {
        static void Main(string[] args)
        {
            long bin = long.Parse(Console.ReadLine());
            long hex;
            int i = 0;
            char[] hexNum = new char[32];
            while (bin > 0)
            {
                hex = bin % 10000;
                bin /= 10000;
                switch (hex)
                {
                    case 0: hexNum[i]='0'; break;
                    case 1: hexNum[i]='1'; break;
                    case 10: hexNum[i]='2'; break;
                    case 11: hexNum[i]='3'; break;
                    case 100: hexNum[i]='4'; break;
                    case 101: hexNum[i]='5'; break;
                    case 110: hexNum[i]='6'; break;
                    case 111: hexNum[i]='7'; break;
                    case 1000: hexNum[i]='8'; break;
                    case 1001: hexNum[i]='9'; break;
                    case 1010: hexNum[i]='A'; break;
                    case 1011: hexNum[i]='B'; break;
                    case 1100: hexNum[i]='C'; break;
                    case 1101: hexNum[i]='D'; break;
                    case 1110: hexNum[i]='E'; break;
                    case 1111: hexNum[i]='F'; break;
                }
                i++;
            }
            for (int j = i-1; j >= 0; j--)
            {
                Console.Write(hexNum[j]);
            }
            Console.WriteLine();
        }
    }
}
