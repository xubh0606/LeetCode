using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _152_MaxProductTests
    {
        [TestMethod()]
        public void MaxProductTest()
        {
            int[] nums = new int[] { 2, 3, -2, 4 };
            _152_MaxProduct solution = new _152_MaxProduct();
            Assert.AreEqual(6, solution.MaxProduct(nums));
        }
    }
}