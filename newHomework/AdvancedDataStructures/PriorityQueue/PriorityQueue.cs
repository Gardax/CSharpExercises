using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class PriorityQueue<T> where T : IComparable
    {
        private List<T> elements;

        public PriorityQueue()
        {
            elements = new List<T>();
        }

        public int Count
        {
            get
            {
                return elements.Count;
            }
        }

        public void Enqueue(T element)
        {
            elements.Add(element);
            int index = elements.Count - 1;
            T movingValue = elements[index];
            int parentIndex = (index - 1) / 2;

            while (index > 0 && movingValue.CompareTo(elements[parentIndex]) > 0)
            {
                elements[index] = elements[parentIndex];
                index = parentIndex;
                parentIndex = (parentIndex - 1) / 2;
            }

            elements[index] = movingValue;
        }

        public void Dequeue()
        {
            int index = 0;
            elements[index] = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            T movingValue = elements[index];

            int currentIndex = 0, leftIndex = 0, rightIndex = 0;

            while (index < elements.Count / 2)
            {
                leftIndex = 2 * index + 1;
                rightIndex = leftIndex + 1;
                if (rightIndex < elements.Count && elements[leftIndex].CompareTo(elements[rightIndex]) < 0)
                {
                    currentIndex = rightIndex;
                }
                else
                {
                    currentIndex = leftIndex;
                }

                if (movingValue.CompareTo(elements[currentIndex]) > 0)
                {
                    break;
                }

                elements[index] = elements[currentIndex];
                index = currentIndex;
            }
            elements[index] = movingValue;
        }

        public T Peek
        {
            get
            {
                return elements[0];
            }
        }
    }
}
