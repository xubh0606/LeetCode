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
    public class _30_FindSubstringSolutionTests
    {
        [TestMethod()]
        public void FindSubstringTest()
        {
            _30_FindSubstringSolution solution = new _30_FindSubstringSolution();
            string s = "barfoothefoobarman";
            string[] arr = new string []{ "foo", "bar"};
            Assert.AreEqual(2, solution.FindSubstring(s, arr).Count);
        }
    }
}