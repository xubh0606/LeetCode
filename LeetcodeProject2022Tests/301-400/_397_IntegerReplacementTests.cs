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
    public class _397_IntegerReplacementTests
    {
        [TestMethod()]
        public void IntegerReplacementTest()
        {
            _397_IntegerReplacement solution = new _397_IntegerReplacement();
            Assert.AreEqual(3, solution.IntegerReplacement(8));
        }
    }
}