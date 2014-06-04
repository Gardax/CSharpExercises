using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Student:Person
    {
        public string classNumber { get; set; }
        public Student(string number, string name)
            : base(name)
        {
            this.classNumber = number;
            this.name = name;
        }
        public List<string> Comments = new List<string>();
        public void AddComment(string text)
        {
            Comments.Add(text);
        }
    }
}
