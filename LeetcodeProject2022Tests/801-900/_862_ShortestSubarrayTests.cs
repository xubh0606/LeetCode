using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _862_ShortestSubarrayTests
    {
        [TestMethod()]
        public void ShortestSubarrayTest()
        {
            int[] nums = new int[] { 2, 0, -1, 2 };
            _862_ShortestSubarray solution = new _862_ShortestSubarray();
            Assert.AreEqual(4, solution.ShortestSubarray(nums, 3));
        }
    }
}