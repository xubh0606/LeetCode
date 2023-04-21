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
    public class _53_MaxSubArrayTests
    {
        [TestMethod()]
        public void MaxSubArrayTest()
        {
            int[] nums = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
            _53_MaxSubArray solution = new _53_MaxSubArray();
            Assert.AreEqual(6, solution.MaxSubArray(nums));
        }
    }
}