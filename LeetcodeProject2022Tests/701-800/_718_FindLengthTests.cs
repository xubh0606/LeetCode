using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _718_FindLengthTests
    {
        [TestMethod()]
        public void FindLengthTest()
        {
            int[] nums1 = new int[] { 0, 1, 1, 1, 1 };
            int[] nums2 = new int[] { 1, 0, 1, 0, 1 };
            _718_FindLength solution = new _718_FindLength();
            Assert.AreEqual(2, solution.FindLength(nums1, nums2));
        }
    }
}