using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemovingItems
{
    class RemovingItems
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers:");
            List<int> list = new List<int>();
            int number;
            int count=7;
            for (int i = 0; i < count; i++)
            {
                number = int.Parse(Console.ReadLine());
                list.Add(number);
            }
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    if (list[i] < list[i + 1])
                    {
                        list.RemoveAt(i);
                        count--;
                        i--;
                    } 
                }
                else if (i == list.Count-1)
                {
                    if (list[i] < list[i - 1])
                    {
                        list.RemoveAt(i);
                        count--;
                        i--;
                    }
                }
                else
                {
                    if (list[i] < list[i + 1] || list[i] < list[i - 1])
                    {
                        list.RemoveAt(i);
                        count--;
                        i--;
                    }
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
