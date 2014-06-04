using System;
using System.Linq;

namespace HashSet
{
    class HashSetMain
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<int> set = new HashSet<int>();
                set.Add(13);
                set.Add(14);
                set.Add(15);
                set.Add(16);
                set.Add(17);
                Console.WriteLine(set.Find(14));
                Console.WriteLine("Count: {0}", set.Count);
                set.Remove(14);
                Console.WriteLine("Count: {0}", set.Count);
                Console.WriteLine(set.Find(14));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
