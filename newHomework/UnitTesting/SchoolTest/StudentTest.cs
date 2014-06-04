using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Name can not be null or empty!")]
        public void TestSetNameNull()
        {
            Student Teodor = new Student("teodor", 11111);
            Teodor.Name = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Unique number must be between 10 000 and 99 999!")]
        public void TestUniqueNumberOutOfRange()
        {
            Student Teodor = new Student("teodor", 11111);
            Teodor.UniqueNumber = 11111111;
        }

        [TestMethod]
        public void TestCreateStudent()
        {
            Student Ivan = new Student("ivan", 34567);
            Assert.AreEqual(Ivan.Name, "ivan");
            Assert.AreEqual(Ivan.UniqueNumber, 34567);
        }
    }
}