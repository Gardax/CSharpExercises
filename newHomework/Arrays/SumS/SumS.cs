using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumS
{
    class SumS
    {
        static void Main(string[] args)
        {
            int[] array={4, 3, 1, 4, 2, 5, 8};
            bool yes = false;
            int s = 11;
            int count = 0, sum = 0,j=1;
            for (int i = 0; i < array.Length; i++)
            {
                if (sum < s)
                {
                    sum += array[i];
                    count++;
                }
                else if (sum > s)
                {
                    i = j;
                    sum = 0;
                    j++;
                    count = 0;
                }
                else
                {
                    for (int z = i - count; z < i; z++)
                    {
                        Console.WriteLine(array[z] + " ");
                        yes = true;
                    }
                }
            }
            if (!yes)
            {
                Console.WriteLine("There are no substring with sum S");
            }

        }
    }
}
