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
    public class _351_NumberOfPatternsTests
    {
        [TestMethod()]
        public void NumberOfPatternsTest()
        {
            int m = 1, n = 2;
            _351_NumberOfPatterns solution = new _351_NumberOfPatterns();
            Assert.AreEqual(65, solution.NumberOfPatterns(m, n));
        }
    }
}