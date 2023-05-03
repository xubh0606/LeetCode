using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _139_WordBreakTests
    {
        [TestMethod()]
        public void WordBreakTest()
        {
            string s = "leetcode";
            string[] wordDict = new string[] { "leet", "code" };
            _139_WordBreak solution = new _139_WordBreak();
            Assert.IsTrue(solution.WordBreak(s, wordDict));
        }
    }
}