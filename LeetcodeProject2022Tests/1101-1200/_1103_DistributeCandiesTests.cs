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
    public class _1103_DistributeCandiesTests
    {
        [TestMethod()]
        public void DistributeCandiesTest()
        {
            int candies = 7, num_people = 4;
            _1103_DistributeCandies solution = new _1103_DistributeCandies();
            Assert.AreEqual(4, solution.DistributeCandies(candies, num_people).Length);
        }
    }
}