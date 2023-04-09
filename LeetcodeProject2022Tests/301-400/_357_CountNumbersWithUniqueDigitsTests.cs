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
    public class _357_CountNumbersWithUniqueDigitsTests
    {
        [TestMethod()]
        public void CountNumbersWithUniqueDigitsTest()
        {
            int n = 2;
            _357_CountNumbersWithUniqueDigits solution = new _357_CountNumbersWithUniqueDigits();
            Assert.AreEqual(91, solution.CountNumbersWithUniqueDigits(n));
        }
    }
}