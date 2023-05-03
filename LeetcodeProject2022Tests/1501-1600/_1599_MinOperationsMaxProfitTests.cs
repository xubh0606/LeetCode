using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1599_MinOperationsMaxProfitTests
    {
        [TestMethod()]
        public void MinOperationsMaxProfitTest()
        {
            int[] customers = new int[] { 8, 3 };
            int boardingCost = 5, runningCost = 6;
            _1599_MinOperationsMaxProfit solution = new _1599_MinOperationsMaxProfit();
            Assert.AreEqual(3, solution.MinOperationsMaxProfit(customers, boardingCost, runningCost));
        }
    }
}