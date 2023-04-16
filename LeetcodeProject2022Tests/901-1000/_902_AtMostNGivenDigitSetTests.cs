using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._901_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000.Tests
{
    [TestClass()]
    public class _902_AtMostNGivenDigitSetTests
    {
        [TestMethod()]
        public void AtMostNGivenDigitSetTest()
        {
            string[] digits = new string[] { "1", "2", "3", "6", "7", "8" };
            int n = 211;
            _902_AtMostNGivenDigitSet solution = new _902_AtMostNGivenDigitSet();
            Assert.AreEqual(79, solution.AtMostNGivenDigitSet(digits, n));
        }

        [TestMethod()]
        public void AtMostNGivenDigitSetTest2()
        {
            string[] digits = new string[] { "1" };
            int n = 834;
            _902_AtMostNGivenDigitSet solution = new _902_AtMostNGivenDigitSet();
            Assert.AreEqual(3, solution.AtMostNGivenDigitSet(digits, n));
        }

        [TestMethod()]
        public void AtMostNGivenDigitSetTest3()
        {
            string[] digits = new string[] { "7" };
            int n = 8;
            _902_AtMostNGivenDigitSet solution = new _902_AtMostNGivenDigitSet();
            Assert.AreEqual(1, solution.AtMostNGivenDigitSet(digits, n));
        }

        [TestMethod()]
        public void AtMostNGivenDigitSetTest1()
        {
            Assert.Fail();
        }
    }
}