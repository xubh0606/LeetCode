using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _7_ReverseTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            _7_Reverse solution = new _7_Reverse();
            Assert.AreEqual(321, solution.Reverse(123));
        }
    }
}