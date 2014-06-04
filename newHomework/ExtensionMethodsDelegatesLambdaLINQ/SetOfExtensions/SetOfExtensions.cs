using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOfExtensions
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> items)
        {
            dynamic sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> items)
        {
            dynamic product = 1;
            foreach (var item in items)
            {
                product=item*product;
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> items)
        {
            dynamic min = int.MaxValue;
            foreach (var item in items)
            {
                if (item < min) min = item;
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> items)
        {
            dynamic max = int.MinValue;
            foreach (var item in items)
            {
                if (max < item) max = item;                
            }
            return max;
        }
        public static T Average<T>(this IEnumerable<T> items)
        {
            dynamic sum = 0;
            int count = 0;
            foreach (var item in items)
            {
                sum += item;
                count++;
            }
            return sum / count;
        }
    }
    class SetOfExtensions
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Product());
        }
    }
}
