using System;
using System.Linq;

namespace HashTable
{
    class HashTableMain
    {
        static void Main(string[] args)
        {
            HashTable<string, int> people = new HashTable<string, int>();
            people.Add("gosho", 14);
            people.Add("tosho", 15);
            people.Add("pesho", 16);
            people.Add("ivan", 20);
            people.Add("stoqn", 40);

            Console.WriteLine("Count {0}", people.Count);
            Console.WriteLine("Gosho is {0} years old.", people["gosho"]);
            people.Remove("gosho");
            Console.WriteLine("Count {0}", people.Count);
            Console.WriteLine(people.Contain("gosho"));
        }
    }
}
