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
    public class _367_IsPerfectSquareTests
    {
        [TestMethod()]
        public void IsPerfectSquareTest()
        {
            int n = 808201;
            _367_IsPerfectSquare solution = new _367_IsPerfectSquare();
            Assert.IsTrue(solution.IsPerfectSquare(n));
        }
    }
}