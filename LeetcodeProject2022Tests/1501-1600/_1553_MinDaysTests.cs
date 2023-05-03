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
    public class _1553_MinDaysTests
    {
        [TestMethod()]
        public void MinDaysTest()
        {
            int n = 10;
            _1553_MinDays solution = new _1553_MinDays();
            Assert.AreEqual(4, solution.MinDays(n));
        }
    }
}