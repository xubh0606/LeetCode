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
    public class _1523_CountOddsTests
    {
        [TestMethod()]
        public void CountOddsTest()
        {
            int low = 8, high = 10;
            _1523_CountOdds solution = new _1523_CountOdds();
            Assert.AreEqual(1, solution.CountOdds(low, high));
        }
    }
}