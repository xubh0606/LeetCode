using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1601_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_.Tests
{
    [TestClass()]
    public class _1566_ContainsPatternTests
    {
        [TestMethod()]
        public void ContainsPatternTest()
        {
            int[] arr = new int[] { 1, 2, 4, 4, 4, 4 };
            int m = 1, k = 3;
            _1566_ContainsPattern solution = new _1566_ContainsPattern();
            Assert.IsTrue(solution.ContainsPattern(arr, m, k));
        }
    }
}