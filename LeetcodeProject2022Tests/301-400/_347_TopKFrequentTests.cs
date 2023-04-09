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
    public class _347_TopKFrequentTests
    {
        [TestMethod()]
        public void TopKFrequentTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 4, 5, 5 };
            _347_TopKFrequent solution = new _347_TopKFrequent();
            Assert.AreEqual(2, solution.TopKFrequent(nums, 2).Length);
        }
    }
}