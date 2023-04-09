using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _575_DistributeCandiesTests
    {
        [TestMethod()]
        public void DistributeCandiesTest()
        {
            int[] candyType = new int[] { 1, 1, 2, 2, 3, 3 };
            _575_DistributeCandies solution = new _575_DistributeCandies();
            Assert.AreEqual(3, solution.DistributeCandies(candyType));
        }
    }
}