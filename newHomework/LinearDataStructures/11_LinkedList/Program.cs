using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            
            numbers.AddFirst(54);
            Console.WriteLine(numbers.Count);

            numbers.AddLast(43);
            Console.WriteLine(numbers.Count);
            
            numbers.RemoveFirst();
            Console.WriteLine(numbers.Count);

        }
    }
}
