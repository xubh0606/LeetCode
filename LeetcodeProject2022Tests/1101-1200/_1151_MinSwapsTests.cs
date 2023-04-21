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
    public class _1151_MinSwapsTests
    {
        [TestMethod()]
        public void MinSwapsTest()
        {
            int[] data = new int[] { 1, 0, 1, 0, 1 };
            _1151_MinSwaps solution = new _1151_MinSwaps();
            Assert.AreEqual(1, solution.MinSwaps(data));
        }
    }
}