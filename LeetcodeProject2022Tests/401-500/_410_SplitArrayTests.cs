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
    public class _410_SplitArrayTests
    {
        [TestMethod()]
        public void SplitArrayTest()
        {
            int[] nums = new int[] { 7, 2, 5, 10, 8 };
            int m = 2;
            _410_SplitArray solution = new _410_SplitArray();
            Assert.AreEqual(18, solution.SplitArray(nums, m));
        }
    }
}