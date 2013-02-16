using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfBigNumbers
{
    class Program
    {
        static int[] sum(int[] num1, int[] num2)
        {
            int[] sum = new int[10000];
            int max = Math.Max(num1.Length, num2.Length)-1;
            int min = Math.Min(num1.Length, num2.Length)-1;
            int j = 0;
            if (num1.Length > num2.Length)
            {
                while (min >= 0)
                {

                    sum[j] =sum[j] + num1[max] + num2[min];
                    if (sum[j] > 9) 
                    {
                        sum[j + 1]++;
                        sum[j] %= 10;
                    }
                    max--;
                    min--;
                    j++;
                }
                j = num2.Length;
                for (int i = max; i >= 0; i--)
                {
                    if (sum[j] > 9)
                    {
                        sum[j + 1]++;
                        sum[j] %= 10;
                    }
                    sum[j] += num1[i];
                    j++;
                }
            }
            else
            {
                while (min >= 0)
                {

                    sum[j] =sum[j]+num2[max] + num1[min];
                    if (sum[j] > 9)
                    {
                        sum[j+1]++;
                        sum[j] %= 10;
                    }
                    max--;
                    min--;
                    j++;
                }
                j = num1.Length;
                for (int i = max; i >= 0; i--)
                {
                    
                    sum[j] += num2[i];
                    if (sum[j] > 9)
                    {
                        sum[j + 1]++;
                        sum[j] %= 10;
                    }
                    j++;
                }
            }
            return sum;
        }
        static int[] toIntArray(char[] arr)
        {
            int[] array=new int[arr.Length];
            string digit;
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i]-'0';
            }
            return array;
        }
        static void Main(string[] args)
        {
            char[] number1 = Console.ReadLine().ToCharArray();
            char[] number2 = Console.ReadLine().ToCharArray();
            int[] number = sum(toIntArray(number1), toIntArray(number2));
            bool flag = false;
            for (int i =number.Length-1; i >=0; i--)
            {
                if (number[i] != 0)
                {
                    flag = true;
                }
                if (flag)
                    Console.Write(number[i]);
                
            }
        }
    }
}
