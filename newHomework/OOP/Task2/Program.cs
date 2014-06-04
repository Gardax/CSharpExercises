using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define list of students
            List<Student> students=new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", 6));
            students.Add(new Student("Georgi", "Georgiev", 11));
            students.Add(new Student("Pesho", "peshov", 1));
            students.Add(new Student("Stamat", "Nesumdomatov", 3));
            students.Add(new Student("Doncho", "Minkov", 5));
            students.Add(new Student("Sasho", "Roman", 8));
            students.Add(new Student("Tosho", "Toshov", 2));
            students.Add(new Student("Krasimir", "Stefanov", 10));
            students.Add(new Student("Veselina", "Vasileva", 7));
            students.Add(new Student("Ivan", "Simeonov", 3));
            //sort by grade
            students=students.OrderBy(student => student.grade).ToList();
            //define list of workers
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Stefan", "Todorov", 120, 8));
            workers.Add(new Worker("Vanya", "Todorova", 140, 7));
            workers.Add(new Worker("Nina", "Todorova", 3000, 5));
            workers.Add(new Worker("Kristian", "Peev", 400, 12));
            workers.Add(new Worker("Chochko", "Ivanov", 150, 7));
            workers.Add(new Worker("Ivan", "Rilski", 1000, 10));
            workers.Add(new Worker("Stilian", "Grozdanov", 800, 14));
            workers.Add(new Worker("Stefani", "Baneva", 200, 8));
            workers.Add(new Worker("Ivanka", "Ivanova", 120, 7));
            workers.Add(new Worker("Pencho", "Prodavacha", 160, 9));
            //sort by salary desending
            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();
            //merge lists
            var mergedlists = workers.Concat<Human>(students).ToList();
            //order by first name then by last name
            mergedlists = mergedlists.OrderBy(list => list.firstName).ThenBy(list => list.lastName).ToList();
           
        }
    }
}
