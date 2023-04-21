using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _392_IsSubsequenceTests
    {
        [TestMethod()]
        public void IsSubsequenceTest()
        {
            string s = "abc", t = "ahbgdc";
            _392_IsSubsequence solution = new _392_IsSubsequence();
            Assert.IsTrue(solution.IsSubsequence(s, t));
        }
    }
}