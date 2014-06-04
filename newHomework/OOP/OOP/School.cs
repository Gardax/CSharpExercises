using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class School
    {
        public string name { get; set; }
        public List<ClassStudents> classes = new List<ClassStudents>();
        public School(string name)
        {
            this.name = name;
        }
    }
}
