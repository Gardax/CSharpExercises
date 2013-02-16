using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultifuctionalProgram
{
    class MultifuctionalProgram
    {
        static int reverseNumber(int num)
        {
            string number = num.ToString();
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            number = new string(array);
            return int.Parse(number);
        }
        static double average(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        static double solveLinearEquation(int a, int b)
        {
            return -b / a;
        }
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
        static void Main(string[] args)
        {
            Console.WriteLine("Type 1 to reverse a number.");
            Console.WriteLine("Type 2 to find average.");
            Console.WriteLine("Type 3 to solve linear equation.");
            string act = Console.ReadLine();
            int number;
            bool result = Int32.TryParse(act, out number);
            bool flag=false;
            while (!result || flag )
            {
                if (number < 1 || number > 3)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                Console.WriteLine("You input was invalid!");
                Console.WriteLine("Type 1 to reverse a number.");
                Console.WriteLine("Type 2 to find average.");
                Console.WriteLine("Type 3 to solve linear equation.");
                act = Console.ReadLine();
                result = Int32.TryParse(act, out number);
            }
            if (number == 1)
            {
                Console.WriteLine("Type number that you want to reverse:");
                number = int.Parse(Console.ReadLine());
                while (number < 0)
                {
                    Console.WriteLine("The number must be bigger than 0!");
                    number=int.Parse(Console.ReadLine());
                }
                Console.WriteLine("The reversed number is {0}",reverseNumber(number));
            }
            if (number == 2)
            {
                Console.WriteLine("Enter sequance of numbers separated with space:");
                string numbers=Console.ReadLine();
                while (numbers.Length < 1)
                {
                    Console.WriteLine("The sequance is empty");
                    Console.WriteLine("Type numbers again separated with space:");
                    numbers = Console.ReadLine();
                }
                int[] array = toIntArray(numbers);
                Console.WriteLine("Average of the numbers is {0}", average(array));
            }
            if (number == 3)
            {
                Console.WriteLine("Type a and b of equation a*x+b=0");
                int a = int.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.WriteLine("a should not be equal to 0");
                    Console.WriteLine("Type it again");
                    a = int.Parse(Console.ReadLine());
                }
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("The answer is {0}", solveLinearEquation(a,b));
            }
        }
    }
}
