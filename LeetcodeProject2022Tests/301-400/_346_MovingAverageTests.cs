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
    public class _346_MovingAverageTests
    {
        [TestMethod()]
        public void _346_MovingAverageTest()
        {
            _346_MovingAverage movingAverage = new _346_MovingAverage(3);
            movingAverage.Next(1); // 返回 1.0 = 1 / 1
            movingAverage.Next(10); // 返回 5.5 = (1 + 10) / 2
            movingAverage.Next(3); // 返回 4.66667 = (1 + 10 + 3) / 3
            movingAverage.Next(5); // 返回 6.0 = (10 + 3 + 5) / 3
        }
    }
}