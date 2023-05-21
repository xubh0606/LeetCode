using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _47_PermuteUniqueTests
    {
        [TestMethod()]
        public void PermuteUniqueTest()
        {
            int[] nums = new int[] { 1, 1, 2 };
            _47_PermuteUnique solution = new _47_PermuteUnique();
            Assert.AreEqual(3, solution.PermuteUnique(nums).Count);
        }
    }
}