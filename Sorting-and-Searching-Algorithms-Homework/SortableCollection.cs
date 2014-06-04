namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].CompareTo(item)==0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T searchedItem)
        {
            int firstIndex = 0;
            int lastIndex = this.items.Count;
            while (lastIndex >= firstIndex)
            {
                int middlePoint = (firstIndex + lastIndex) / 2;
                if (this.items[middlePoint].CompareTo(searchedItem)<0)
                {
                    firstIndex = middlePoint + 1;
                }
                else if(this.items[middlePoint].CompareTo(searchedItem)>0)
                {
                    lastIndex=middlePoint-1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Shuffles the collection items performing
        /// Fisher-Yates algorithm. Algoritm complexity O(n)
        /// </summary>
        public void Shuffle()
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < this.items.Count; i++)
            {
                T swap=this.items[i];
                int randIndex = randomGenerator.Next(i, this.items.Count);
                this.items[i] = this.items[randIndex];
                this.items[randIndex] = swap;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
