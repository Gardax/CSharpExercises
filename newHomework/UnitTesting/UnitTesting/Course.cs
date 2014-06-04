using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Course
    {
        private string name;
        public List<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (students.Count <= 30)
            {
                students.Add(student);
            }
            else 
            {
                throw new ArgumentOutOfRangeException("This course is full!");
            }
        }

        public void RemoveStudentByUniqueNumber(int uniqueNumber)
        {
            bool isRemoved = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].UniqueNumber == uniqueNumber)
                {
                    students.RemoveAt(i);
                    isRemoved = true;
                }
            }
            if (!isRemoved)
            {
                throw new ArgumentException("There is no such student in this course");
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != null && value !="")
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name can not be null or empty!");
                }
            }
        }
    }
}
