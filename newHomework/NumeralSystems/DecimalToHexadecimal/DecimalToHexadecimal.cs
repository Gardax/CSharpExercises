using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            int[] hex = new int[32];
            int number = int.Parse(Console.ReadLine());
            int j = 0;
            while (number > 0)
            {
                hex[j] = number % 16;
                number /= 16;
                j++;
            }
            for (int i = j - 1; i >= 0; i--)
            {
                switch (hex[i])
                {
                    case 0: Console.Write("0"); break;
                    case 1: Console.Write("1"); break;
                    case 2: Console.Write("2"); break;
                    case 3: Console.Write("3"); break;
                    case 4: Console.Write("4"); break;
                    case 5: Console.Write("5"); break;
                    case 6: Console.Write("6"); break;
                    case 7: Console.Write("7"); break;
                    case 8: Console.Write("8"); break;
                    case 9: Console.Write("9"); break;
                    case 10: Console.Write("A"); break;
                    case 11: Console.Write("B"); break;
                    case 12: Console.Write("C"); break;
                    case 13: Console.Write("D"); break;
                    case 14: Console.Write("E"); break;
                    case 15: Console.Write("F"); break;
                }
            }
            Console.WriteLine();
        }
    }
}
