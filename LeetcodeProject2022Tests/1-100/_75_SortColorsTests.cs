using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _75_SortColorsTests
    {
        [TestMethod()]
        public void SortColorsTest()
        {
            int[] nums = new int[] { 2, 0, 2, 1, 1, 0 };
            _75_SortColors solution = new _75_SortColors();
            solution.SortColors(nums);
            Assert.AreEqual(0, nums[0]);
        }
    }
}