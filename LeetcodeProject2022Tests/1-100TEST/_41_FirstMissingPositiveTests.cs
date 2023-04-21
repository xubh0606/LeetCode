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
    public class _41_FirstMissingPositiveTests
    {
        [TestMethod()]
        public void FirstMissingPositiveTest()
        {
            int[] nums = new int[] { 1, 2, 0 };
            _41_FirstMissingPositive solution = new _41_FirstMissingPositive();
            Assert.AreEqual(3, solution.FirstMissingPositive(nums));
        }

        [TestMethod()]
        public void FirstMissingPositiveTest2()
        {
            int[] nums = new int[] { 7, 8, 9, 11, 12 };
            _41_FirstMissingPositive solution = new _41_FirstMissingPositive();
            Assert.AreEqual(1, solution.FirstMissingPositive(nums));
        }
    }
}