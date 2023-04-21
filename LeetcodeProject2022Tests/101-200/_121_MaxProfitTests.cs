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
    public class _121_MaxProfitTests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            _121_MaxProfit soltuon = new _121_MaxProfit();
            int[] price = new int[] { 7, 1, 5, 3, 6, 4 };
            Assert.AreEqual(5, soltuon.MaxProfit(price));
        }
    }
}