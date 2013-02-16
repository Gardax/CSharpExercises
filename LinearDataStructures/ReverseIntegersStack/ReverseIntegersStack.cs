using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseIntegersStack
{
    class ReverseIntegersStack
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int number;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                stack.Push(number);
            }
            Stack<int> ReversedStack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                number = stack.Pop();
                ReversedStack.Push(number);
            }

        }
    }
}
