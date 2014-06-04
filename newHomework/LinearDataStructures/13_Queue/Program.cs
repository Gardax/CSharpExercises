using System;
using System.Linq;

namespace _13_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> numbers = new LinkedQueue<int>();
            
            numbers.Enqueue(5);
            numbers.Enqueue(6);
            numbers.Enqueue(7);
            numbers.Enqueue(8);
            numbers.Enqueue(2);
            Console.WriteLine("Count of numbers: {0}.",numbers.Count);

            Console.WriteLine("Remove number: {0}.",numbers.Dequeue());
            Console.WriteLine("Remove number: {0}.", numbers.Dequeue());
            Console.WriteLine("Count of numbers: {0}.", numbers.Count);
        }
    }
}
