using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _413_NumberOfArithmeticSlicesTests
    {
        [TestMethod()]
        public void NumberOfArithmeticSlicesTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            _413_NumberOfArithmeticSlices solution = new _413_NumberOfArithmeticSlices();
            Assert.AreEqual(3, solution.NumberOfArithmeticSlices(nums));
        }
    }
}