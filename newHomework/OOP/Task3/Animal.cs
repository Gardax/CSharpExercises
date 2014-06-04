using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public Animal(string name, int age, string sex)
        {
            this.sex = sex;
            this.name = name;
            this.age = age;
        }
        public static double Average(Animal[] animals)
        {
            double sum = 0;
            for (int i = 0; i < animals.Count(); i++)
            {
                sum = sum + animals[i].age;
            }
            return sum / animals.Length;
        }
    }
}
