using System;
using System.Linq;

namespace _12_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(4);
            numbers.Push(5);
            numbers.Push(5);
            numbers.Push(6);
            numbers.Push(7);
            numbers.Push(2);
            numbers.Push(22);
            numbers.Push(33);
            numbers.Push(14);
            Console.WriteLine(numbers.Count);

            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers.Peek());
            Console.WriteLine(numbers.Count);

            Console.WriteLine(numbers.Contains(5));
            Console.WriteLine(numbers.Contains(55));

            numbers.Clear();
            numbers.Push(44);
            Console.WriteLine(numbers.Count);
        }
    }
}
