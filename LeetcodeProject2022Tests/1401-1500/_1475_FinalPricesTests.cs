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
    public class _1475_FinalPricesTests
    {
        [TestMethod()]
        public void FinalPricesTest()
        {
            int[] prices = new int[] { 8, 4, 6, 2, 3 };
            _1475_FinalPrices solution = new _1475_FinalPrices();
            //[4, 2, 4, 2, 3]
            Assert.AreEqual(4, solution.FinalPrices(prices));
        }
    }
}