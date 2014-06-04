using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            BiDictionary<string, string, string> dictionary = new BiDictionary<string, string, string>();
            dictionary.Add("Lovech", "man", "Georgi Georgiev");
            dictionary.Add("Lovech", "woman", "Nina Todorova");
            dictionary.Add("Lovech", "woman", "Martina Nikolova");
            dictionary.Add("Sofia", "woman", "Elizabet Sokolova");
            dictionary.Add("Lovech", "man", "Tosho Kyltyrista");

            Console.WriteLine("People from Lovech:");
            foreach (var item in dictionary.FindByFistKey("Lovech"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Girls:");
            var girls = dictionary.FindBySecondKey("woman");
            foreach (var girl in girls)
            {
                Console.WriteLine(girl);
            }

            Console.WriteLine();
            Console.WriteLine("Me and Tosho");
            foreach (var person in dictionary.FindByBothKeys("Lovech", "man"))
            {
                Console.WriteLine(person);
            }
        }
    }
}
