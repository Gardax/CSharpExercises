using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
            School.AddStudent(this);
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (value != null && value != "")
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name can not be null or empty!");
                }
            }
        }

        public int UniqueNumber
        {
            get { return this.uniqueNumber; }
            set
            {
                if (value >= 10000 && value <= 99999)
                {
                    this.uniqueNumber = value;
                }
                else
                {
                    throw new ArgumentException("Unique number must be between 10 000 and 99 999!");
                }
            }
        }

    }
}
