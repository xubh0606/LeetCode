using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1401_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500.Tests
{
    [TestClass()]
    public class _1458_MaxDotProductTests
    {
        [TestMethod()]
        public void MaxDotProductTest()
        {
            int[] nums1 = new int[] { 2, 1, -2, 5 };
            int[] nums2 = new int[] { 3, 0, -6 };
            _1458_MaxDotProduct solution = new _1458_MaxDotProduct();
            Assert.AreEqual(18, solution.MaxDotProduct(nums1, nums2));
        }
    }
}