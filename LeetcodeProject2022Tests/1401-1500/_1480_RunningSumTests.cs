using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1401_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500.Tests
{
    [TestClass()]
    public class _1480_RunningSumTests
    {
        [TestMethod()]
        public void RunningSumTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            _1480_RunningSum solution = new _1480_RunningSum();
            Assert.AreEqual(10, solution.RunningSum(nums)[3]);
        }
    }
}