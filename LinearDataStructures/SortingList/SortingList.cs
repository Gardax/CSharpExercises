using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingList
{
    class SortingList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string number = "0";
            int num;
            do
            {

                number = Console.ReadLine();
                if (number != String.Empty)
                {
                    num = int.Parse(number);
                    list.Add(num);
                }
            }
            while (number != String.Empty);
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
