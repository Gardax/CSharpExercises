using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetOfKElements
{
    class SubsetOfKElements
    {
        static void Main(string[] args)
        {
            int n, k, s;
            Console.WriteLine("Type N:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Type K:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Type S:");
            s = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Fill the array:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            bool yes = false;
            int sum = 0;
            for (int i = 0; i < array.Length-k; i++)
            {
                for (int z = 0; z < k; z++)
                {
                    sum += array[i + z];
                }
                if (sum == s)
                {
                    Console.WriteLine("That's sequance with sum S and K elements:");
                    for (int z = 0; z < k; z++)
                    {
                        Console.WriteLine(array[i + z]);
                    }
                    yes = true;
                    break;
                }
                else 
                {
                    sum = 0;
                }
            }
            if (!yes)
            {
                Console.WriteLine("There are no substring with sum S and K elements");
            }

        }
    }
}
