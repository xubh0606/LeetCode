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
    public class _14_LongestCommonPrefixTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            string[] strs = new string[] { "flower", "flow", "flight" };
            _14_LongestCommonPrefix solution = new _14_LongestCommonPrefix();
            Assert.AreEqual("fl", solution.LongestCommonPrefix(strs));
        }
    }
}