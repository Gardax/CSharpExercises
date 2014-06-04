using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public static class School
    {

        public static List<Student> Students=new List<Student>();
        public static void AddStudent(Student student)
        {
            
            for (int i = 0; i < Students.Count; i++)
			{
			    if (Students[i].UniqueNumber == student.UniqueNumber)
                {
                    throw new ArgumentException("There is student with the same unique number!");
                }
			}
            Students.Add(student);
        }
    }
}
