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
    public class _5_LongestPalindromeTests
    {
        [TestMethod()]
        public void LongestPalindromeTest()
        {
            string s = "babad";
            _5_LongestPalindrome solution = new _5_LongestPalindrome();
            Assert.AreEqual(3, solution.LongestPalindrome(s).Length);
        }

        [TestMethod()]
        public void LongestPalindromeTest2()
        {
            string s = "ac";
            _5_LongestPalindrome solution = new _5_LongestPalindrome();
            Assert.AreEqual(1, solution.LongestPalindrome(s).Length);
        }
    }
}