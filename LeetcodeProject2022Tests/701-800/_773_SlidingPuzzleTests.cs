using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _773_SlidingPuzzleTests
    {
        [TestMethod()]
        public void SlidingPuzzleTest()
        {
            int[][] board = ChangeStringToList.GetArrOfArrForInt("[[1, 2, 3],[4, 0, 5]]");
            _773_SlidingPuzzle solution = new _773_SlidingPuzzle();
            Assert.AreEqual(1, solution.SlidingPuzzle(board));
        }
    }
}