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
    public class _84_LargestRectangleAreaTests
    {
        [TestMethod()]
        public void LargestRectangleAreaTest()
        {
            int[] heights = new int[]{2, 1, 5, 6, 2, 3};
            _84_LargestRectangleArea solution = new _84_LargestRectangleArea();
            Assert.AreEqual(10, solution.LargestRectangleArea(heights));
        }
    }
}