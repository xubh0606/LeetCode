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
    public class _365_CanMeasureWaterTests
    {
        [TestMethod()]
        public void CanMeasureWaterTest()
        {
            int jug1Capacity = 3, jug2Capacity = 5, targetCapacity = 4;
            _365_CanMeasureWater solution = new _365_CanMeasureWater();
            Assert.IsTrue(solution.CanMeasureWater(jug1Capacity, jug2Capacity, targetCapacity));
        }
    }
}