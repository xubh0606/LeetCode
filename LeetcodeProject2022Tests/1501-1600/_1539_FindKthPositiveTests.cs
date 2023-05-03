using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1539_FindKthPositiveTests
    {
        [TestMethod()]
        public void FindKthPositiveTest()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            int k = 2;
            _1539_FindKthPositive solution = new _1539_FindKthPositive();
            Assert.AreEqual(6, solution.FindKthPositive(arr, k));
        }
    }
}