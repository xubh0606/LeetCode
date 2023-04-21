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
    public class _313_NthSuperUglyNumberTests
    {
        [TestMethod()]
        public void NthSuperUglyNumberTest()
        {
            int n = 12;
            int[] primes = new int[] { 2, 7, 13, 19 };
            _313_NthSuperUglyNumber solution = new _313_NthSuperUglyNumber();
            Assert.AreEqual(32, solution.NthSuperUglyNumber(n, primes));
        }
    }
}