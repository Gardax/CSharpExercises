using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Discipline
    {
        public string name { get; set; }
        public int numberOfLectures { get; set; }
        public int numberOfExercises { get; set; }
        public Discipline(string name, int lectures, int exercises)
        {
            this.name = name;
            this.numberOfLectures = lectures;
            this.numberOfExercises = exercises;
        }
        public List<string> Comments = new List<string>();
        public void AddComment(string text)
        {
            Comments.Add(text);
        }
    }
}
