using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _494_FindTargetSumWaysTests
    {
        [TestMethod()]
        public void FindTargetSumWaysTest()
        {
            int[] nums = new int[] { 1, 1, 1, 1, 1 };
            int target = 3;
            _494_FindTargetSumWays solution = new _494_FindTargetSumWays();
            Assert.AreEqual(5, solution.FindTargetSumWays(nums, target));
        }
    }
}