using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _204_CountPrimesTests
    {
        [TestMethod()]
        public void CountPrimesTest()
        {
            _204_CountPrimes solution = new _204_CountPrimes();
            Assert.AreEqual(4, solution.CountPrimes(10));
        }
    }
}