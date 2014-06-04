using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Worker:Human
    {
        public int weekSalary { get; set; }
        public int workHoursPerDay { get; set; }
        public Worker(string first, string last, int salary, int hours)
            : base(first, last)
        {
            this.firstName = first;
            this.lastName = last;
            this.weekSalary = salary;
            this.workHoursPerDay = hours;
        }
        public int MoneyPerHour()
        {
            return this.weekSalary / (7 * this.workHoursPerDay);
        }
    }
}
