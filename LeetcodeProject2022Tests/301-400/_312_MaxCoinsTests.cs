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
    public class _312_MaxCoinsTests
    {
        [TestMethod()]
        public void MaxCoinsTest()
        {
            int[] nums = new int[] { 3, 1, 5, 8 };
            _312_MaxCoins solution = new _312_MaxCoins();
            Assert.AreEqual(167, solution.MaxCoins(nums));
        }
    }
}