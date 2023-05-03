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
    public class _64_MinPathSumTests
    {
        [TestMethod()]
        public void MinPathSumTest()
        {
            _64_MinPathSum solution = new _64_MinPathSum();
            int[][] grid = new int[][] { new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 } };
            Assert.AreEqual(7, solution.MinPathSum(grid));
        }
    }
}