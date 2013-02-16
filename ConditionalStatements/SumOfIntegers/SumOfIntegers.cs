using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfIntegers
{
    class SumOfIntegers
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[] numbers = new int[N];
            int[] first = new int[N-1];
            int sum = 0;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                numbers[i]=int.Parse(Console.ReadLine());
            }
            /*for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j< numbers.Length-1; j++)
                {
                    sum = numbers[i] + numbers[j];
                    if (sum == 0) Console.WriteLine(numbers[i] + numbers[j]);

                }
            }*/
            while (true)
            {
                sum = numbers[count] + numbers[count + 1];
                if (sum==0)
                {
                    Console.WriteLine(numbers[count]+ numbers[count+1]);
                }
                sum=
            }
        }
    }
}
