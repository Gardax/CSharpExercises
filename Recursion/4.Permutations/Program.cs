using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Permutations
{
    class Program
    {
        static int[] result;
        static bool[] usedNumbers;

        private static void PrintPermutations(int index, int n)
        {
            if (index >= n)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }
            else 
            {
                for (int i = 1; i <=n; i++)
                {
                    if (!usedNumbers[i])
                    {
                        result[index] = i;
                        usedNumbers[i] = true;
                        PrintPermutations(index + 1, n);
                        usedNumbers[i] = false;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            result = new int[n];
            usedNumbers = new bool[n+1];
            PrintPermutations(0, n);
        }
    }
}
