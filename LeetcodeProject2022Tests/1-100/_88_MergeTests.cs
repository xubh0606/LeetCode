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
    public class _88_MergeTests
    {
        [TestMethod()]
        public void MergeTest()
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new int[] { 2, 5, 6 };
            int m = 3, n = 3;
            _88_Merge solution = new _88_Merge();
            solution.Merge(nums1, m, nums2, n);
            Assert.AreEqual(6, nums1[5]);
        }
    }
}