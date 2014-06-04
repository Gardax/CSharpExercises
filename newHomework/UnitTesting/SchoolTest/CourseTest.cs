using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestAddStudentToCourse()
        {
            Course it = new Course("IT");
            Student Ivan = new Student("ivan", 34587);
            it.AddStudent(Ivan);
            Assert.AreEqual(it.students.Count, 1);
        }

        [TestMethod]
        [ExpectedException (typeof(ArgumentOutOfRangeException), "This course is full!")]
        public void TestAddStudentToFullCourse()
        {
            Course it = new Course("IT");
            for (int i = 50000; i < 50032; i++)
            {
                Student Ivan = new Student("Ivan", i);
                it.AddStudent(Ivan);
            }
        }

        [TestMethod]
        public void TestRemoveStudentByUniqueNumber()
        {
            Course it = new Course("IT");
            Student Ivan = new Student("ivan", 34597);
            it.AddStudent(Ivan);
            it.RemoveStudentByUniqueNumber(34597);
        }
        [TestMethod]
        [ExpectedException (typeof(ArgumentException))]
        public void TestRemoveStudentByUniqueNumberThatDoesNotExist()
        {
            Course it = new Course("IT");
            Student Ivan = new Student("ivan", 34517);
            it.AddStudent(Ivan);
            it.RemoveStudentByUniqueNumber(999999);
        }
    }
}
