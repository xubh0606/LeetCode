using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _128_LongestConsecutiveTests
    {
        [TestMethod()]
        public void LongestConsecutiveTest()
        {
            int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };
            _128_LongestConsecutive solution = new _128_LongestConsecutive();
            Assert.AreEqual(4, solution.LongestConsecutive(nums));
        }
    }
}