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
    public class _164_MaximumGapTests
    {
        [TestMethod()]
        public void MaximumGapTest()
        {
            int[] nums = new int[] { 3, 6, 9, 1 };
            _164_MaximumGap solution = new _164_MaximumGap();
            Assert.AreEqual(3, solution.MaximumGap(nums));
        }
    }
}