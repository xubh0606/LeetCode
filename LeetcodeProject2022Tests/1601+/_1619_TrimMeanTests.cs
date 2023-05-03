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
    public class _1619_TrimMeanTests
    {
        [TestMethod()]
        public void TrimMeanTest()
        {
            int[] arr = new int[] { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 };
            _1619_TrimMean solution = new _1619_TrimMean();
            Assert.AreEqual(2, solution.TrimMean(arr));
        }
    }
}