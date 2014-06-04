using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem
{
    //enumerations 
    public enum University
    {
        SU, TU, NBU, UNSS
    }

    public enum Faculty
    {
        Philosophy, Law, Mathematics, Phisics, Business, Management, Telecommunications
    }

    public enum Specialty
    {
        Telecommunications, Marketing, Business, Entrepreneurship, Phisics, Mathematics, Informatics, Law, Philosophy
    }
    class Student:ICloneable,IComparable<Student>
    {
        //all data about student
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string address;
        private string phone;
        private string email;
        private int course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public int Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        public Specialty Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }
        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        public Faculty Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }
        public int SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        //constructor
        public Student(string firstName, string middleName, string lastName, string address, string phone, string email, int course, int ssn, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Address = address;
            this.Phone = phone;
            this.Course = course;
            this.SSN = ssn;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
            this.Email = email;
        }
        //overriding ToString to returns all information about the student
        public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            build.AppendLine(this.FirstName);
            build.AppendLine(this.MiddleName);
            build.AppendLine(this.LastName);
            build.AppendLine(this.Address);
            build.AppendLine(this.Phone.ToString());
            build.AppendLine(this.Course.ToString());
            build.AppendLine(this.SSN.ToString());
            build.AppendLine(this.Specialty.ToString());
            build.AppendLine(this.University.ToString());
            build.AppendLine(this.Faculty.ToString());

            return build.ToString();
        }
        //overriding Equals
        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student != null && Object.Equals(this.FirstName, student.FirstName) && Object.Equals(this.LastName, student.LastName)
                && this.SSN == SSN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //overriding == to compare students
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }
        //overriding != to compare students
        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }
        //overriding GetHashCodde
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SSN.GetHashCode();
        }
        //Clone student
        public Student Clone()
        {
            Student result = new Student(this.firstName, this.middleName, this.lastName, this.address, this.phone, this.email, this.course, 
                this.ssn, this.specialty, this.university, this.faculty);
            return result;
        }
        Object ICloneable.Clone()
        {
            return this.Clone();
        }
        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }
            if (this.MiddleName != student.MiddleName)
            {
                return (this.MiddleName.CompareTo(student.MiddleName));
            }
            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }
        }
}
