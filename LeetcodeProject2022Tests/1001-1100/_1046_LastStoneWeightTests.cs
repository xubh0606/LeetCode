using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1001_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100.Tests
{
    [TestClass()]
    public class _1046_LastStoneWeightTests
    {
        [TestMethod()]
        public void LastStoneWeightTest()
        {
            int[] stones = new int[] { 2, 7, 4, 1, 8, 1 };
            _1046_LastStoneWeight solution = new _1046_LastStoneWeight();
            Assert.AreEqual(1, solution.LastStoneWeight(stones));
        }
    }
}