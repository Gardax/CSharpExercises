using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinAndMaxNumber
{
    class MinAndMaxNumber
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers;
            numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); 
            }

            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i]) min = numbers[i];
                if (max < numbers[i]) max = numbers[i];
            }
            Console.WriteLine("The minimum element is: "+min);
            Console.WriteLine("The maximum element is:"+max);
        }
    }
}
