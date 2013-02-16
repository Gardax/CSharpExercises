using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace SetOfIntegerNumbers
{
    class SetOfIntegerNumbers
    {
        static int[] toIntArray(string arr)
        {
            string[] numbers = arr.Split(' ');
            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }
            return array;
        }
        static int findMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }
        static int findMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        static double findAverage(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        static int findSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static BigInteger findProduct (int[] arr)
        {
            BigInteger product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sequance of numbers separated with space:");
            string inputNumbers = Console.ReadLine();
            int[] numbers = toIntArray(inputNumbers);
            Console.WriteLine("The min element is {0}", findMin(numbers));
            Console.WriteLine("The max element is {0}", findMax(numbers));
            Console.WriteLine("Average is {0}", findAverage(numbers));
            Console.WriteLine("The sum is {0}", findSum(numbers));
            Console.WriteLine("The product is {0}", findProduct(numbers));
        }
    }
}
