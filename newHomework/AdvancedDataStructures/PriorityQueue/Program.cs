using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

            priorityQueue.Enqueue(10);
            priorityQueue.Enqueue(11);
            priorityQueue.Enqueue(21);
            priorityQueue.Enqueue(44);
            priorityQueue.Enqueue(23);
            priorityQueue.Enqueue(6);
            priorityQueue.Enqueue(60);

            Console.WriteLine("The biggest element: {0} ", priorityQueue.Peek);
            priorityQueue.Dequeue();

            Console.WriteLine("The biggest element: {0}", priorityQueue.Peek);

            priorityQueue.Enqueue(70);
            Console.WriteLine("The biggest element: {0} ", priorityQueue.Peek);
        }
    }
}
