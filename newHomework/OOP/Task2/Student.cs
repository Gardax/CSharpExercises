using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student:Human
    {
        public int grade { get; set; }
        public Student(string first, string last, int grade)
            : base(first, last)
        {
            this.firstName = first;
            this.lastName = last;
            this.grade = grade;
        }
    }
}
