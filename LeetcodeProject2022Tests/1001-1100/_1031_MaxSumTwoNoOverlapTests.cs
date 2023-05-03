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
    public class _1031_MaxSumTwoNoOverlapTests
    {
        [TestMethod()]
        public void MaxSumTwoNoOverlapTest()
        {
            int[] nums = new int[] { 0, 6, 5, 2, 2, 5, 1, 9, 4 };
            int firstLen = 1, secondLen = 2;
            _1031_MaxSumTwoNoOverlap solution = new _1031_MaxSumTwoNoOverlap();
            Assert.AreEqual(20, solution.MaxSumTwoNoOverlap(nums, firstLen, secondLen));
        }
    }
}