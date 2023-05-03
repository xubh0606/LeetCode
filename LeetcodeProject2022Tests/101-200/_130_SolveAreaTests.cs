using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _130_SolveAreaTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            string s = "[ X ,  X ,  X ,  X ],[ X ,  O ,  O ,  X ],[ X ,  X ,  O ,  X ],[ X ,  O ,  X ,  X ]]";
           char[][] board = ChangeStringToCharArr.GetCharArr(s);
            _130_SolveArea solution = new _130_SolveArea();
            solution.Solve(board);
            Assert.AreEqual('X', board[1][1]);
            Assert.AreEqual('X', board[1][2]);
        }
    }
}