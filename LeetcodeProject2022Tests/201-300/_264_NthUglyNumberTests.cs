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
    public class _264_NthUglyNumberTests
    {
        [TestMethod()]
        public void NthUglyNumberTest()
        {
            int n = 10;
            _264_NthUglyNumber solution = new _264_NthUglyNumber();
            Assert.AreEqual(12, solution.NthUglyNumber(n));
        }
    }
}