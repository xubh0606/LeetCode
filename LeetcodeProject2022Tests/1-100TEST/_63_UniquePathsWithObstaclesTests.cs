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
    public class _63_UniquePathsWithObstaclesTests
    {
        [TestMethod()]
        public void UniquePathsWithObstaclesTest()
        {
            int[][] obstacleGrid = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } };
            _63_UniquePathsWithObstacles solution = new _63_UniquePathsWithObstacles();
            Assert.AreEqual(2, solution.UniquePathsWithObstacles(obstacleGrid));
        }
    }
}