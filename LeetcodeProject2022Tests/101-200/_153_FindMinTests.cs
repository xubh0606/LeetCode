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
    public class _153_FindMinTests
    {
        [TestMethod()]
        public void FindMinTest()
        {
            int[] nums = new int[] { 3, 4, 5, 1, 2 };
            _153_FindMin solution = new _153_FindMin();
            Assert.AreEqual(1, solution.FindMin(nums));
        }
    }
}