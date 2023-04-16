using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _805_SplitArraySameAverageTests
    {
        [TestMethod()]
        public void SplitArraySameAverageTest()
        {
            int[] nums = new int[]{1, 2, 3, 4, 5, 6, 7, 8};
            _805_SplitArraySameAverage solution = new _805_SplitArraySameAverage();
            Assert.IsTrue(solution.SplitArraySameAverage(nums));
        }
    }
}