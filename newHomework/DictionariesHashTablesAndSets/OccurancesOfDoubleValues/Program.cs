using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurancesOfDoubleValues
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> occurances = new Dictionary<double, int>();
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
            foreach (var number in occurances)
            {
                Console.WriteLine("{0} -> {1} times.",number.Key, number.Value);
            }
        }
    }
}
