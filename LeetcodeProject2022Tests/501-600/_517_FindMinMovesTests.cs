using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _517_FindMinMovesTests
    {
        [TestMethod()]
        public void FindMinMovesTest()
        {
            int[] machines = new int[]{ 1, 0, 5};
            _517_FindMinMoves solution = new _517_FindMinMoves();
            Assert.AreEqual(3, solution.FindMinMoves(machines));
        }
    }
}