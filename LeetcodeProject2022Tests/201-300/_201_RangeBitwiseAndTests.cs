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
    public class _201_RangeBitwiseAndTests
    {
        [TestMethod()]
        public void RangeBitwiseAndTest()
        {
            int left = 5, right = 7;
            _201_RangeBitwiseAnd solution = new _201_RangeBitwiseAnd();
            Assert.AreEqual(4, solution.RangeBitwiseAnd(left, right));
        }
    }
}