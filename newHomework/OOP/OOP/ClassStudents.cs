using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ClassStudents
    {
        public List<Teacher> teachers = new List<Teacher>();
        public List<Student> students = new List<Student>();
        public string ID { get; set; }
        public ClassStudents(string id)
        {
            this.ID = id;
        }

        public List<string> Comments = new List<string>();
        public void AddComment(string text)
        {
            Comments.Add(text);
        }
    }
}
