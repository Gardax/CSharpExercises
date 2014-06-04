using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsLambdaExpressionsLINQ
{
    class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public Student(string first, string last, int age)
        {
            this.firstName = first;
            this.lastName = last;
            this.age = age;
        }
    }
}
