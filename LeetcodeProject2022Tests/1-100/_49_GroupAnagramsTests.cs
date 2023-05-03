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
    public class _49_GroupAnagramsTests
    {
        [TestMethod()]
        public void GroupAnagramsTest()
        {
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            _49_GroupAnagrams solution = new _49_GroupAnagrams();
            Assert.AreEqual(3, solution.GroupAnagrams(strs).Count);
        }
    }
}