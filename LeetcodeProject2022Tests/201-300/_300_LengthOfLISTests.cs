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
    public class _300_LengthOfLISTests
    {
        [TestMethod()]
        public void LengthOfLISTest()
        {
            int[] nums = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            _300_LengthOfLIS solution = new _300_LengthOfLIS();
            Assert.AreEqual(4, solution.LengthOfLIS(nums));
        }
    }
}