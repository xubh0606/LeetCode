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
    public class _349_IntersectionTests
    {
        [TestMethod()]
        public void IntersectionTest()
        {
            int[] nums1 = new int[] { 1, 2, 2, 1 }, nums2 = new int[] { 2, 2 };
            _349_Intersection solution = new _349_Intersection();
            Assert.AreEqual(2, solution.Intersection(nums1, nums2)[0]);
        }
    }
}