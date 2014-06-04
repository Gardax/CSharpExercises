using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_LinkedList
{
    public class ListItem<T>
    {
        private T value;
        private ListItem<T> nextItem;

        public T Value
        {
            get
            {
                return this.value;
            }
            set 
            {
                this.value = value;
            }
        }

        public ListItem<T> NextItem
        {
            get
            {
                return this.nextItem;
            }
            set
            {
                this.nextItem = value;
            }
        }

        public ListItem(T value, ListItem<T> nextItem = null)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }
    }
}
