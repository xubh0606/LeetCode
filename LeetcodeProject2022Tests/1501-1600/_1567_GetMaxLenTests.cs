using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1567_GetMaxLenTests
    {
        [TestMethod()]
        public void GetMaxLenTest()
        {
            int[] nums = new int[] { 0, 1, -2, -3, -4 };
            _1567_GetMaxLen solution = new _1567_GetMaxLen();
            Assert.AreEqual(3, solution.GetMaxLen(nums));
        }
    }
}