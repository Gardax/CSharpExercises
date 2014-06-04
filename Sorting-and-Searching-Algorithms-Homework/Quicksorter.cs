namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null || collection.Count == 0)
            {
                throw new ArgumentNullException("The collection can not be null or empty");
            }
            this.QuickSort(collection, 0, collection.Count-1);
        }
        private void QuickSort(IList<T> collection, int left, int right)
        {
            int p;
            if (left >= right)
            {
                return;
            }

            p = this.Partition(collection, left, right);

            this.QuickSort(collection, left, p - 1);
            this.QuickSort(collection, p + 1, right);
        }

        private int Partition(IList<T> collection, int left, int right)
        {
            int first = left;
            int pivot = right--;
            while (left <= right)
            {
                while (collection[left].CompareTo(collection[pivot]) < 0)
                {
                    left++;
                }

                while ((right >= first) && (collection[right].CompareTo(collection[pivot]) >= 0))
                {
                    right--;
                }

                if (left < right)
                {
                    this.Swap(collection, left, right);
                    left++;
                }
            }
            if (left != pivot)
                this.Swap(collection, left, pivot);

            return left;
        }

        private void Swap(IList<T> collection, int i, int j)
        {
            T temp = collection[i];
            collection[i] = collection[j];
            collection[j] = temp;
        }
    }
}
