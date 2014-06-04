using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.NesetedLoops
{
    class Program
    {

        static void GenerateNumbers(int[] arr, int index, int numberOfLoops)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine("(" + String.Join(", ", arr) + ")");
            }
            else
            {
                for (int i = 1; i <= numberOfLoops; i++)
                {
                    arr[index] = i;
                    GenerateNumbers(arr, index + 1, numberOfLoops);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            GenerateNumbers(vector, 0, n);
        }
    }
}
