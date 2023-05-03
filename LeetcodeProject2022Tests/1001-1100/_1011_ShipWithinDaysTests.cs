using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1001_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100.Tests
{
    [TestClass()]
    public class _1011_ShipWithinDaysTests
    {
        [TestMethod()]
        public void ShipWithinDaysTest()
        {
            int[] weights = new int[] { 10, 20, 100, 100, 100, 100, 50, 100 };
            _1011_ShipWithinDays solution = new _1011_ShipWithinDays();
            Assert.AreEqual(150, solution.ShipWithinDays(weights, 5));
        }
    }
}