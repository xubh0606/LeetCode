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
    public class _10_IsMatchTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
            string s = "aab", p = "c*a*b";
            _10_IsMatch solution = new _10_IsMatch();
            Assert.IsTrue(solution.IsMatch(s, p));
        }

        [TestMethod()]
        public void IsMatchTest2()
        {
            string s = "ab", p = ".*c";
            _10_IsMatch solution = new _10_IsMatch();
            Assert.IsTrue(solution.IsMatch(s, p));
        }
    }
}