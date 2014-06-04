using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintElementsTharPresentsOddNumberOfTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array={"C#", "SQL", "PHP", "PHP", "SQL", "SQL" } ;
            Dictionary<string, int> occurances = new Dictionary<string, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (occurances.ContainsKey(array[i]))
                {
                    occurances[array[i]] += 1;
                }
                else
                {
                    occurances[array[i]] = 1;
                }
            }

            //print
            foreach (var item in occurances)
            {
                if (item.Value % 2 == 1)
                {
                    Console.WriteLine("{0} -> {1} times.", item.Key, item.Value);
                }
            }
        }
    }
}
