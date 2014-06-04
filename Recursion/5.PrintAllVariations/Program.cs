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
        static string[] set={"hi", "a", "b"};

        private static void PrintVariations(int index, int n, int k)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }
            else 
            {
                for (int i = 0; i <n; i++)
                {
                   result[index] =  set[i];
                   PrintVariations(index+1, n, k);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = 3;
            int k = 2;

            result = new string[n];

            PrintVariations(0, n, k);
        }
    }
}
