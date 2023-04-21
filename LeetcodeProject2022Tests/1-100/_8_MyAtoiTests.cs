using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _8_MyAtoiTests
    {
        [TestMethod()]
        public void MyAtoiTest()
        {
            string s = "42";
            _8_MyAtoi solution = new _8_MyAtoi();
            Assert.AreEqual(42, solution.MyAtoi(s));
        }

        [TestMethod()]
        public void MyAtoiTest2()
        {
            string s = "   -42";
            _8_MyAtoi solution = new _8_MyAtoi();
            Assert.AreEqual(-42, solution.MyAtoi(s));
        }

        [TestMethod()]
        public void MyAtoiTest3()
        {
            string s = "-21474836482";
            _8_MyAtoi solution = new _8_MyAtoi();
            Assert.AreEqual(-2147483648, solution.MyAtoi(s));
        }
    }
}