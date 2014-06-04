using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4.Balls
{
    class Program
    {
        static void Main()
        {
            char[] balls = Console.ReadLine().ToCharArray();

            long sequencesCount = CountSequences(balls);
            Console.WriteLine(sequencesCount);
        }

        private static long CountSequences(char[] balls)
        {
            HashSet<string> sequences = new HashSet<string>();
            GenerateAllPermutations(balls, 0, sequences);
            return sequences.Count;
        }

        private static void GenerateAllPermutations(char[] balls, int start, HashSet<string> sequences)
        {
            if (start == balls.Length - 1)
            {
                sequences.Add(new String(balls));
                return;
            }
            GenerateAllPermutations(balls, start + 1, sequences);
            for (int i = start; i < balls.Length; i++)
            {
                Swap(ref balls[start], ref balls[i]);
                GenerateAllPermutations(balls, start + 1, sequences);
                Swap(ref balls[start], ref balls[i]);
            }
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            T old = first;
            first = second;
            second = old;
        }
    }
}
