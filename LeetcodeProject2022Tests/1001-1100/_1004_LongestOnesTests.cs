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
    public class _1004_LongestOnesTests
    {
        [TestMethod()]
        public void LongestOnesTest()
        {
            int[] nums = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            int k = 2;
            _1004_LongestOnes solution = new _1004_LongestOnes();
            Assert.AreEqual(6, solution.LongestOnes(nums, k));
        }
    }
}