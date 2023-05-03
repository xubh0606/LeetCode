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
    public class _719_SmallestDistancePairTests
    {
        [TestMethod()]
        public void SmallestDistancePairTest()
        {
            int[] nums = new int[] { 1, 6, 1 };
            int k = 3;
            _719_SmallestDistancePair solution = new _719_SmallestDistancePair();
            Assert.AreEqual(5, solution.SmallestDistancePair(nums, k));
        }

        [TestMethod()]
        public void SmallestDistancePairTest2()
        {
            int[] nums = new int[] { 62, 100, 4 };
            int k = 2;
            _719_SmallestDistancePair solution = new _719_SmallestDistancePair();
            Assert.AreEqual(58, solution.SmallestDistancePair(nums, k));
        }
    }
}