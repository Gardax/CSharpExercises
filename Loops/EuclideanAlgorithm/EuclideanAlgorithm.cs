using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EuclideanAlgorithm
{
    class EuclideanAlgorithm
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int gcd;
            while (firstNum != secondNum)
            {
                if (firstNum > secondNum)
                {
                    firstNum = firstNum - secondNum;
                }
                else
                {
                    secondNum = secondNum - firstNum;
                }
            }
            gcd = firstNum;
            Console.WriteLine(gcd);
        }
    }
}
