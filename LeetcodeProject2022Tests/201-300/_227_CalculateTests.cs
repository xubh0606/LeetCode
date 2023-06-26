using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _227_CalculateTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            string s = " 3+5 / 2 ";
            _227_Calculate solution = new _227_Calculate();
            Assert.AreEqual(5, solution.Calculate(s));
        }

        [TestMethod()]
        public void CalculateTest2()
        {
            string s = " 1 + 1 ";
            _227_Calculate solution = new _227_Calculate();
            Assert.AreEqual(2, solution.Calculate(s));
        }
    }
}