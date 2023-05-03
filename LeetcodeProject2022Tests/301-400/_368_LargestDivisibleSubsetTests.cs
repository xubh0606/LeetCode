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
    public class _368_LargestDivisibleSubsetTests
    {
        [TestMethod()]
        public void LargestDivisibleSubsetTest()
        {
            int[] nums = new int[] { 1, 2, 3 };
            _368_LargestDivisibleSubset solution = new _368_LargestDivisibleSubset();
            Assert.AreEqual(2, solution.LargestDivisibleSubset(nums).Count);
        }
    }
}