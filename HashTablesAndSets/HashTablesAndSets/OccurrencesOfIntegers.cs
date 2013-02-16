using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTablesAndSets
{
    class OccurrencesOfIntegers
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            IDictionary<int,int> numbers=new Dictionary<int,int>();
            int i = 0;
            foreach (int number in array)
            {

                numbers.Add(i,number);
                i++;
            }

            int length = array.Length;
            int count;
            
        }
    }
}
