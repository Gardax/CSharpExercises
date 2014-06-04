using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "There is student with the same unique number!")]
        public void TestAddStudentWithSameUniqueNumber()
        {
            //The constructor of the class Student add new Student to School
            Student gosho = new Student("Gosho", 10001);
            Student tosho = new Student("Tosho Kato Gosho", 10001);
        }
    }
}
