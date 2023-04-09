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
    public class _322_CoinChangeTests
    {
        [TestMethod()]
        public void CoinChangeTest()
        {
            int[] coins = new int[] { 1, 2, 5 };
            int amount = 11;
            _322_CoinChange solution = new _322_CoinChange();
            Assert.AreEqual(3, solution.CoinChange(coins, amount));
        }
    }
}