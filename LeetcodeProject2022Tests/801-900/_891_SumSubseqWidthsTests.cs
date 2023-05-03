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
    public class _891_SumSubseqWidthsTests
    {
        [TestMethod()]
        public void SumSubseqWidthsTest()
        {
            int[] nums = new int[] { 2, 1, 3 };
            _891_SumSubseqWidths solution = new _891_SumSubseqWidths();
            Assert.AreEqual(6, solution.SumSubseqWidths(nums));
        }
    }
}