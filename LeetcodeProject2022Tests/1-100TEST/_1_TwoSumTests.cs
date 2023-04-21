using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022Tests._1_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._1_200.Tests
{
    [TestClass()]
    public class _1_TwoSumTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            _1_TwoSum solution = new _1_TwoSum();
            int[] nums = new int[] { 2, 7, 11, 15 };
            Assert.AreEqual(2, solution.TwoSum(nums, 9).Length);
        }
    }
}