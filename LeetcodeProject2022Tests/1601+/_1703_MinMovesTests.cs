using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1601_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_.Tests
{
    [TestClass()]
    public class _1703_MinMovesTests
    {
        [TestMethod()]
        public void MinMovesTest()
        {
            int[] nums = new int[] { 1, 0, 0, 1, 0, 1 };
            int k = 2;
            _1703_MinMoves solution = new _1703_MinMoves();
            Assert.AreEqual(1, solution.MinMoves(nums, k));
        }
    }
}