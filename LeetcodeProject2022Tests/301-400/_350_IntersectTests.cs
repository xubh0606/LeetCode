using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _350_IntersectTests
    {
        [TestMethod()]
        public void IntersectTest()
        {
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            _350_Intersect solution = new _350_Intersect();
            Assert.AreEqual(2, solution.Intersect(nums1, nums2).Length);
        }
    }
}