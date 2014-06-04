using System;
using System.Collections.Generic;
using System.Linq;

namespace BiDictionary
{
    public class BiDictionary<T, K, L>
    {
        private Dictionary<T, List<L>> firstKeyTable;
        private Dictionary<K, List<L>> secondKeyTable;
        private Dictionary<string, List<L>> bothKeysTable;
        public BiDictionary()
        {
            this.firstKeyTable = new Dictionary<T, List<L>>();
            this.secondKeyTable = new Dictionary<K, List<L>>();
            this.bothKeysTable = new Dictionary<string, List<L>>();
        }

        public void Add(T firstKey, K secondKey, L value)
        {
            if (this.firstKeyTable.ContainsKey(firstKey))
            {
                this.firstKeyTable[firstKey].Add(value);
            }
            else
            {
                this.firstKeyTable.Add(firstKey, new List<L> { value });
            }

            if (this.secondKeyTable.ContainsKey(secondKey))
            {
                this.secondKeyTable[secondKey].Add(value);
            }
            else
            {
                this.secondKeyTable.Add(secondKey, new List<L> { value });
            }

            if (this.bothKeysTable.ContainsKey(firstKey.ToString() + secondKey.ToString()))
            {
                this.bothKeysTable[firstKey.ToString() + secondKey.ToString()].Add(value);
            }
            else
            {
                this.bothKeysTable.Add(firstKey.ToString() + secondKey.ToString(), new List<L> { value });
            }
        }

        public List<L> FindByFistKey(T key)
        {
            return this.firstKeyTable[key];
        }

        public List<L> FindBySecondKey(K key)
        {
            return this.secondKeyTable[key];
        }

        public List<L> FindByBothKeys(T firstKey, K secondKey)
        {
            return this.bothKeysTable[firstKey.ToString() + secondKey.ToString()];
        }
    }
}
