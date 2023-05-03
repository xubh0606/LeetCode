using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022Tests._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._201_300.Tests
{
    [TestClass()]
    public class _215_FindKthLargestTests
    {
        [TestMethod()]
        public void FindKthLargestTest()
        {
            int[] nums = new int[] { 7, 6, 5, 4, 3, 2, 1};
            _215_FindKthLargest solution = new _215_FindKthLargest();
            Assert.AreEqual(6, solution.FindKthLargest(nums, 2));
        }
    }
}