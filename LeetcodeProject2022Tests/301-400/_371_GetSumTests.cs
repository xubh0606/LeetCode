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
    public class _371_GetSumTests
    {
        [TestMethod()]
        public void GetSumTest()
        {
            int a = -100;
            int b = 1000;
            _371_GetSum solution = new _371_GetSum();
            Assert.AreEqual(900, solution.GetSum(a, b));
        }
    }
}