using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1101_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200.Tests
{
    [TestClass()]
    public class _1124_LongestWPITests
    {
        [TestMethod()]
        public void LongestWPITest()
        {
            int[] hours = new int[] { 6, 9 };
            _1124_LongestWPI solution = new _1124_LongestWPI();
            Assert.AreEqual(1, solution.LongestWPI(hours));
        }
    }
}