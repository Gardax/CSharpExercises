using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_ReadAndReverseNumbers
{
    class ReadAndReverseNumbers
    {
        static void Main(string[] args)
        {
            //Read numbers
            int N = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                int number=int.Parse(Console.ReadLine());
                numbers.Push(number);
            }

            //Reverse numbers
            Stack<int> reversedNumbers = new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                int number = numbers.Pop();
                reversedNumbers.Push(number);
            }
        }
    }
}
