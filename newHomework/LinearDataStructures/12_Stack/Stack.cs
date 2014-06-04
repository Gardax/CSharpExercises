using System;
using System.Linq;

namespace _12_Stack
{
    public class Stack<T>
    {
        private T[] array;
        private int count;
        private int capacity;

        public Stack(int capacity=4)
        {
            this.array = new T[capacity];
            this.count = 0;
            this.capacity = capacity;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Push(T item)
        {
            if (this.count >= this.capacity)
            {
                Resize();
            }
            array[this.count] = item;
            this.count++;
        }

        public T Peek()
        {
            return this.array[this.count-1];
        }

        public T Pop()
        {
            this.count--;
            if (this.count < 0)
            {
                throw new IndexOutOfRangeException("The stack is empty!");
            }

            return this.array[this.count];
        }

        public void Clear()
        {
            this.count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T[] ToArray()
        {
            T[] newArray = new T[this.count];
            for (int i = 0; i < this.count; i++)
            {
                newArray[i] = this.array[i];
            }

            return newArray;
        }

        public void TrimExcess()
        {
            T[] newArray = new T[this.count];
            for (int i = 0; i < this.count; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
            this.capacity = this.count;
        }

        private void Resize()
        {
            T[] newArray = new T[this.capacity * 2];
            for (int i = 0; i < this.count; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
            this.capacity *= 2;
        }
    }
}
