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
    public class _140_WordBreak2Tests
    {
        [TestMethod()]
        public void WordBreakTest()
        {
            string s = "catsanddog";
            string[] wordDict = new string[] { "cat", "cats", "and", "sand", "dog" };
            _140_WordBreak2 solution = new _140_WordBreak2();
            string res1 = "cats and dog", res2 = "cat sand dog";
            Assert.IsTrue(solution.WordBreak(s, wordDict).Count ==2);
        }
    }
}