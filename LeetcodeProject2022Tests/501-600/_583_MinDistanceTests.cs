using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _583_MinDistanceTests
    {
        [TestMethod()]
        public void MinDistanceTest()
        {
            string word1 = "sea", word2 = "eat";
            _583_MinDistance solution = new _583_MinDistance();
            Assert.AreEqual(2, solution.MinDistance(word1, word2));
        }
    }
}