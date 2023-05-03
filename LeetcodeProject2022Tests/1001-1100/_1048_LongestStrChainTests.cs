using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1001_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100.Tests
{
    [TestClass()]
    public class _1048_LongestStrChainTests
    {
        [TestMethod()]
        public void LongestStrChainTest()
        {
            string[] words = new string[] { "a", "b", "ba", "bca", "bda", "bdca" };
            _1048_LongestStrChain solution = new _1048_LongestStrChain();
            Assert.AreEqual(4, solution.LongestStrChain(words));
        }
    }
}