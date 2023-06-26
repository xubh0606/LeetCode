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
    public class _72_MinDistanceTests
    {
        [TestMethod()]
        public void MinDistanceTest()
        {
            string word1 = "horse", word2 = "ros";
            _72_MinDistance solution = new _72_MinDistance();
            Assert.AreEqual(3, solution.MinDistance(word1, word2));
        }
    }
}