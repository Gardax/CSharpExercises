using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace DataStructuresAndEfficiency
{
    class Program
    {
        static OrderedMultiDictionary<string, Student> students = new OrderedMultiDictionary<string, Student>(true);

        static string FindStudentsByCourse(string course)
        {
            var result = students[course];
            if (!result.Any())
            {
                return "No students found";
            }

            return string.Join(", ", result);
        }

        static void Main(string[] args)
        {
            Console.SetIn(new System.IO.StreamReader("../../students.txt"));

            for (string line = null; (line = Console.ReadLine()) != null; )
            {
                var match = line.Split('|').Select(m => m.Trim()).ToArray();

                students[match[2]].Add(new Student(match[0], match[1]));
            }

            Console.WriteLine(string.Join(Environment.NewLine,
           students.Keys.Select(course =>
               string.Format("{0}: {1}", course, FindStudentsByCourse(course)))));
        }
    }
}
