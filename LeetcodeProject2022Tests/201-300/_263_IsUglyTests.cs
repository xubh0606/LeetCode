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
    public class _263_IsUglyTests
    {
        [TestMethod()]
        public void IsUglyTest()
        {
            int n = 6;
            _263_IsUgly solution = new _263_IsUgly();
            Assert.IsTrue(solution.IsUgly(n));
        }
    }
}