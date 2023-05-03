using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _875_MinEatingSpeedTests
    {
        [TestMethod()]
        public void MinEatingSpeedTest()
        {
            int[] piles = new int[] { 3, 6, 7, 11 };
            int h = 8;
            _875_MinEatingSpeed solution = new _875_MinEatingSpeed();
            Assert.AreEqual(4, solution.MinEatingSpeed(piles, h));
        }
    }
}