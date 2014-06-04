using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PrintAllVariations
{
    class Program
    {
        static string[] result;
        static string[] set = {"test", "rock", "fun"};

        private static void PrintVariations(int index, int k, int start)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }
            else
            {
                for (int i = start; i < set.Length; i++)
                {
                    result[index] = set[i];
                    PrintVariations(index + 1, k, i+1);
                }
            }
        }

        static void Main(string[] args)
        {
            int k = 2;

            result = new string[k];

            PrintVariations(0, k, 0);
        }
    }
}
