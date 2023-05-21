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
    public class _44_IsMatchTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
            string s = "mississippi";
            string p = "m??*ss*?i*pi";
            _44_IsMatch solution = new _44_IsMatch();
            Assert.IsTrue(solution.IsMatch(s, p));
        }

        [TestMethod()]
        public void IsMatchTest2()
        {
            string s = "adceb";
            string p = "*a*b";
            _44_IsMatch solution = new _44_IsMatch();
            Assert.IsFalse(solution.IsMatch(s, p));
        }

        [TestMethod()]
        public void IsMatchTest3()
        {
            string s = "abcabczzzde";
            string p = "*abc???de*";
            _44_IsMatch solution = new _44_IsMatch();
            Assert.IsTrue(solution.IsMatch(s, p));
        }
    }
}