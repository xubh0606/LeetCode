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
    public class _1092_ShortestCommonSupersequenceTests
    {
        [TestMethod()]
        public void ShortestCommonSupersequenceTest()
        {
            string str1 = "abac", str2 = "cab";
            _1092_ShortestCommonSupersequence solution = new _1092_ShortestCommonSupersequence();
            Assert.AreEqual("cabac", solution.ShortestCommonSupersequence(str1, str2));
        }
    }
}