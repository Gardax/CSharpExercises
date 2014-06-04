using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Teacher:Person
    {
        public List<Discipline> disciplines = new List<Discipline>();
        public Teacher(string name):base(name)
        {
            this.name=name;
        }
        public List<string> Comments = new List<string>();
        public void AddComment(string text)
        {
            Comments.Add(text);
        }
    }
}
