using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1590_MinSubarrayTests
    {
        [TestMethod()]
        public void MinSubarrayTest()
        {
            int[] nums = new int[] { 3, 19, 32, 12, 35, 26, 31, 34, 64, 53, 12, 14, 17, 7, 7, 20, 49, 49, 53, 7, 34, 30, 15, 41, 59, 15, 51, 42, 34, 6, 62, 44};
            int p = 25;
            _1590_MinSubarray solution = new _1590_MinSubarray();
            Assert.AreEqual(2, solution.MinSubarray(nums, p));
        }
    }
}