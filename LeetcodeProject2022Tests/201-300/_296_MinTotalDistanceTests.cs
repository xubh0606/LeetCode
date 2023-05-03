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
    public class _296_MinTotalDistanceTests
    {
        [TestMethod()]
        public void MinTotalDistanceTest()
        {
            int[][] grid = ChangeStringToList.GetArrOfArrForInt("[[1, 0, 0, 0, 1],[0, 0, 0, 0, 0],[0, 0, 1, 0, 0]]");
            _296_MinTotalDistance solution = new _296_MinTotalDistance();
            Assert.AreEqual(6, solution.MinTotalDistance(grid));
        }
    }
}