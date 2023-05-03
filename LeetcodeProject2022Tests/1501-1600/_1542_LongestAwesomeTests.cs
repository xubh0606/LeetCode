using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1542_LongestAwesomeTests
    {
        [TestMethod()]
        public void LongestAwesomeTest()
        {
            string s = "3242415";
            _1542_LongestAwesome solution = new _1542_LongestAwesome();
            Assert.AreEqual(5, solution.LongestAwesome(s));
        }
    }
}