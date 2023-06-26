using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _228_SummaryRangesTests
    {
        [TestMethod()]
        public void SummaryRangesTest()
        {
            int[] nums = new int[] { 0, 1, 2, 4, 5, 7 };
            _228_SummaryRanges solution = new _228_SummaryRanges();
            Assert.AreEqual(3, solution.SummaryRanges(nums).Count);
        }
    }
}