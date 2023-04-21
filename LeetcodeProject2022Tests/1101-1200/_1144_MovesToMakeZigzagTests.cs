using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1101_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200.Tests
{
    [TestClass()]
    public class _1144_MovesToMakeZigzagTests
    {
        [TestMethod()]
        public void MovesToMakeZigzagTest()
        {
            int[] nums = new int[] { 9, 6, 1, 6, 2 };
            _1144_MovesToMakeZigzag solution = new _1144_MovesToMakeZigzag();
            Assert.AreEqual(4, solution.MovesToMakeZigzag(nums));
        }
    }
}