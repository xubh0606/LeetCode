using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1201_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300.Tests
{
    [TestClass()]
    public class _1247_MinimumSwapTests
    {
        [TestMethod()]
        public void MinimumSwapTest()
        {
            string s1 = "xy", s2 = "yx";
            _1247_MinimumSwap solution = new _1247_MinimumSwap();
            Assert.AreEqual(2, solution.MinimumSwap(s1, s2));
        }
    }
}