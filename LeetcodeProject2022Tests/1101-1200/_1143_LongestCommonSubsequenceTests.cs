using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1101_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200.Tests
{
    [TestClass()]
    public class _1143_LongestCommonSubsequenceTests
    {
        [TestMethod()]
        public void LongestCommonSubsequenceTest()
        {
            string text1 = "abcde", text2 = "ace";
            _1143_LongestCommonSubsequence solution = new _1143_LongestCommonSubsequence();
            Assert.AreEqual(3, solution.LongestCommonSubsequence(text1, text2));
        }
    }
}