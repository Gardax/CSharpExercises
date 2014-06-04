using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4_LongestSubsequance;
using System.Collections.Generic;

namespace LinearDataStructuresTest
{
    [TestClass]
    public class LongestsubsequanceTest
    {
        [TestMethod]
        public void FindTheLongestSubsequanceTest()
        {
            List<int> numbers = new List<int>() { 4,5,6,2,2,3,3,3,8,5 };

            string expectedOutput="3, 3, 3";
            List<int> sequance = LongestSubsequance.FindTheLongestSubsequance(numbers);
            string output =string.Join(", ", sequance);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        [ExpectedException (typeof(ArgumentNullException))]
        public void FindTheLongestSubsequanceWithNullParametresTest()
        {
            List<int> numbers = new List<int>();
            List<int> sequance = LongestSubsequance.FindTheLongestSubsequance(numbers);
        }

        [TestMethod]
        public void FindTheLongestSubsequanceTest2()
        {
            List<int> numbers = new List<int>() { 4, 5, 6, 2, 3, 8, 5 };

            string expectedOutput = numbers[0].ToString();
            List<int> sequance = LongestSubsequance.FindTheLongestSubsequance(numbers);
            string output = string.Join(", ", sequance);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void FindTheLongestSubsequanceTest3()
        {
            List<int> numbers = new List<int>() { 4, 3, 2, 2, 2, 3, 5, 5, 5, 5, 5, 6, 6 };

            string expectedOutput = "5, 5, 5, 5, 5";
            List<int> sequance = LongestSubsequance.FindTheLongestSubsequance(numbers);
            string output = string.Join(", ", sequance);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}
