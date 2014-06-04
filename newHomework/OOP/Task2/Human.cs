using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Human
    {
        public string firstName;
        public string lastName;
        public Human(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
        }
    }
}
