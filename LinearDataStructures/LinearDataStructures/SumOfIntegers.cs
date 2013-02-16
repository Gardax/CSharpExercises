using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinearDataStructures
{
    class SumOfIntegers
    {
        static void Main(string[] args)
        {
            List<int> list =new List<int>();
            string number="0";
            int num;
            do
            {
                
                number = Console.ReadLine();
                if (number!=String.Empty)
                {
                    num = int.Parse(number);
                    list.Add(num);
                }
            }
            while (number!=String.Empty);
            int sum = 0;
            foreach (int number2 in list)
            {
                sum += number2;
            }
            Console.WriteLine(sum);
            int average = list.Count/2;
            Console.WriteLine(list[average]);
        }
    }
}
