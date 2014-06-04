using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.Passwords
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            int numberOfCombinations = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    numberOfCombinations *= 2;
                }
            }
            Console.WriteLine("The number of combinations is: {0}", numberOfCombinations);
        }
    }
}
