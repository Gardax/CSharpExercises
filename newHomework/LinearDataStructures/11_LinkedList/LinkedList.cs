using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_LinkedList
{
    public class LinkedList<T>
    {
        private int count;

        public ListItem<T> FirstItem { get; set; }

        public int Count 
        {
            get 
            {
                return this.count;
            }
        }

        public LinkedList()
        {
            this.FirstItem = null;
        }

        public void AddFirst(T value)
        {
            if (this.FirstItem == null)
            {
                this.FirstItem = new ListItem<T>(value);
                this.count++;
            }
            else
            {
                ListItem<T> newItem = new ListItem<T>(value);
                newItem.NextItem = this.FirstItem;
                this.FirstItem = newItem;
                this.count++;
            }
        }

        public void AddLast(T value)
        {
            ListItem<T> newItem = new ListItem<T>(value);
            if (this.FirstItem == null)
            {
                this.FirstItem = newItem;
                this.count++;
            }
            else
            {
                ListItem<T> nextItem = this.FirstItem;

                while (nextItem.NextItem != null)
                {
                    nextItem=nextItem.NextItem;
                }
                nextItem.NextItem = newItem;
                this.count++;
            }
        }

        public void RemoveFirst()
        {
            if (this.FirstItem == null)
            {
                throw new Exception("The List is empty!");
            }
            ListItem<T> item = this.FirstItem.NextItem;
            this.FirstItem = item;
            this.count--;
        }

        public void RemoveLast()
        {
            if (this.FirstItem == null)
            {
                throw new Exception("The List is empty!");
            }

            ListItem<T> itemToDelete = this.FirstItem;
            while (itemToDelete.NextItem != null)
            {
                itemToDelete = itemToDelete.NextItem;
            }
            itemToDelete = null;
        }

    }
}
