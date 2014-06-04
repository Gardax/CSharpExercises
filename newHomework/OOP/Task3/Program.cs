using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog[] frogs =
            {
                new Frog("Toni", 4, "female"),
                new Frog("Ivancho", 3, "female"),
                new Frog("Kirkor", 5, "male"),
                new Frog("Kroki", 2, "male")
            };
            Dog[] dogs =
            {
                new Dog("Topcho", 10, "male"),
                new Dog("Bary", 4 , "male"),
                new Dog("Lindzi", 5, "female")
            };
            Cat[] cats =
            {
                new Kitten("Jessy", 3),
                new Kitten("Sara", 2),
                new Tomcat("Tom", 3),
                new Tomcat("Murko", 2)
            };
            cats[1].SaySomething();
            dogs[1].SaySomething();
            frogs[3].SaySomething();
            Console.WriteLine();
            Console.WriteLine("Average age of frogs " + Animal.Average(frogs));
            Console.WriteLine("Average age of dogs " + Animal.Average(dogs));
            Console.WriteLine("Average age of cats " + Animal.Average(cats));
        }
    }
}
