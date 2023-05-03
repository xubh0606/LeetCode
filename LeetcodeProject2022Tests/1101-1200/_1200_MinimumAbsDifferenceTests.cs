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
    public class _1200_MinimumAbsDifferenceTests
    {
        [TestMethod()]
        public void MinimumAbsDifferenceTest()
        {
            int[] arr = new int[] { 4, 2, 1, 3 };
            _1200_MinimumAbsDifference solution = new _1200_MinimumAbsDifference();
            Assert.AreEqual(3, solution.MinimumAbsDifference(arr).Count);
        }
    }
}