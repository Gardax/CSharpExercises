using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem
{
    class Person
    {
        //information about person
        public string name;
        public int? age;
        public string Name
        {
            get { return this.name;}
            set { this.name = value; }
        }
        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Person(string name, int? age = null)
        {
            this.name = name;
            this.age = age;
        }
        //overridin ToString to display information about person
        public override string ToString()
        {
            if (this.age != null)
            {
                return string.Format("Name:" + this.name + " Age: " + this.age);
            }
            else
            {
                return string.Format("Name:" + this.name + " Age: Not specified");
            }
        }
    }
}
