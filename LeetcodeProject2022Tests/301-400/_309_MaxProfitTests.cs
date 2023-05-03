using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _309_MaxProfitTests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            int[] prices = new int[] { 1, 2, 3, 0, 2 };
            _309_MaxProfit solution = new _309_MaxProfit();
            Assert.AreEqual(3, solution.MaxProfit(prices));
        }
    }
}