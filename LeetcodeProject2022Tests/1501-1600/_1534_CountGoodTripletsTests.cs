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
    public class _1534_CountGoodTripletsTests
    {
        [TestMethod()]
        public void CountGoodTripletsTest()
        {
            int[] arr = new int[] { 3, 0, 1, 1, 9, 7 };
            int a = 7, b = 2, c = 3;
            _1534_CountGoodTriplets solution = new _1534_CountGoodTriplets();
            Assert.AreEqual(4, solution.CountGoodTriplets(arr, a, b, c));
        }
    }
}