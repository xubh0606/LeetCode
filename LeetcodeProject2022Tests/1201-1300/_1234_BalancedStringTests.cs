using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1201_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300.Tests
{
    [TestClass()]
    public class _1234_BalancedStringTests
    {
        [TestMethod()]
        public void BalancedStringTest()
        {
            string s = "QQWE";
            _1234_BalancedString solution = new _1234_BalancedString();
            Assert.AreEqual(1, solution.BalancedString(s));
        }
    }
}