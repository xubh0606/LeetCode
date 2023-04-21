using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._901_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000.Tests
{
    [TestClass()]
    public class _909_SnakesAndLaddersTests
    {
        [TestMethod()]
        public void SnakesAndLaddersTest()
        {
            int[][] board = ChangeStringToList.GetArrOfArrForInt("[[-1, -1, -1, -1, -1, -1],[-1, -1, -1, -1, -1, -1],[-1, -1, -1, -1, -1, -1],[-1, 35, -1, -1, 13, -1],[-1, -1, -1, -1, -1, -1],[-1, 15, -1, -1, -1, -1]]");
            _909_SnakesAndLadders solution = new _909_SnakesAndLadders();
            Assert.AreEqual(4, solution.SnakesAndLadders(board));
        }
    }
}