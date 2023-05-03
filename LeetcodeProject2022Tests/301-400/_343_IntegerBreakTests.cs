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
    public class _343_IntegerBreakTests
    {
        [TestMethod()]
        public void IntegerBreakTest()
        {
            _343_IntegerBreak solution = new _343_IntegerBreak();
            Assert.AreEqual(36, solution.IntegerBreak(10));
        }
    }
}