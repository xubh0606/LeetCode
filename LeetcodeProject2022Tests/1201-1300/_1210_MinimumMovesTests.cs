using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1201_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300.Tests
{
    [TestClass()]
    public class _1210_MinimumMovesTests
    {
        [TestMethod()]
        public void MinimumMovesTest()
        {
            int[][] grid = ChangeStringToList.GetArrOfArrForInt("[[0,0,0,0,1,1],[1,1,0,0,0,1],[1,1,1,0,0,1],[1,1,1,0,1,1],[1,1,1,0,0,1],[1,1,1,0,0,0]]");
            _1210_MinimumMoves solution = new _1210_MinimumMoves();
            Assert.AreEqual(11, solution.MinimumMoves(grid));
        }

        [TestMethod()]
        public void MinimumMovesTest2()
        {
            int[][] grid = ChangeStringToList.GetArrOfArrForInt("[[0,0,1,0,0,0,0,0,0,0,0,0,0,0,0],[0,1,0,1,1,0,0,1,0,0,0,0,1,0,0],[0,1,0,0,0,0,1,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,1,0,0,0,0,0,0,0,0],[0,0,0,0,0,0,1,1,0,0,0,0,0,0,0],[0,0,0,0,0,0,0,0,0,1,0,1,0,0,0],[0,0,0,0,0,0,0,0,0,0,0,0,0,0,0],[0,0,0,1,0,1,0,0,1,0,0,0,1,0,0],[0,0,0,0,1,0,0,0,0,0,0,0,0,1,0],[0,0,0,0,0,0,0,0,0,0,0,0,0,0,0],[0,0,0,1,0,0,0,0,0,0,0,0,0,0,0],[1,0,1,1,0,0,0,0,0,0,0,0,0,0,0],[0,0,0,0,0,0,0,0,0,0,0,0,0,1,0],[1,0,0,0,0,0,1,0,0,0,1,0,0,0,1],[0,0,1,0,1,0,0,0,0,0,0,0,0,0,0]]");
            _1210_MinimumMoves solution = new _1210_MinimumMoves();
            Assert.AreEqual(29, solution.MinimumMoves(grid));
        }
    }
}