using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsLambdaExpressionsLINQ
{
    static class OperateStudents
    {
        //find students whose first name is before its last name alphabetically
        public static void Find(Student[] students)
        {
            var arr=from student in students
            where student.firstName.CompareTo(student.lastName) == -1
            select student;
            foreach (var student in arr)
            {
                Console.WriteLine(student.firstName + " "+ student.lastName);
            }
        }
        //find students with age between 18 and 24
        public static void FindBetween18and24(Student[] students)
        {
            var arr = from student in students
                      where student.age>18 && student.age<24
                      select student;
            foreach (var student in arr)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }
        }
        //order by first then last name using lambda
        static void OrderBy(Student[] students)
        {
            var sorted=students.OrderBy(student => student.firstName).ThenBy(student => student.lastName);
            foreach (var student in sorted)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }
        }
        // order be first then last name using LINQ
        static void OrderByLINQ(Student[] students)
        {
            var sorted = from student in students
                         orderby student.firstName, student.lastName
                         select student;
            foreach (var student in sorted)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }
        }
        static void Main(string[] args)
        {
            Student[] students = 
            {
                new Student("Georgi", "Georgiev", 17),
                new Student("Kiril", "Banev",26),
                new Student("Ivan", "Vrachanski",23)
            };
            Find(students);
            Console.WriteLine();
            FindBetween18and24(students);
            Console.WriteLine();
            OrderBy(students);
            Console.WriteLine();
            OrderByLINQ(students);
        }
    }
}
