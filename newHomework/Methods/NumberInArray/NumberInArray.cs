using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInArray
{
    class NumberInArray
    {
        static int counter(int[] arr, int num)
        {
            int count=0;
            for (int i = 0; i < arr.Length; i++)
			{
			    if(arr[i]==num) count++;
			}
            return count;
        }
        static void Main(string[] args)
        {
            int number;
            int[] array = new int[10];
            Console.WriteLine("Which is number that you are looking for?");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Fill the array!");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Method says that it's found the number {0} times!", counter(array, number));
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number) count++;
            }
            Console.WriteLine("Program says that it's founs the number {0} times!", count);
        }
    }
}
