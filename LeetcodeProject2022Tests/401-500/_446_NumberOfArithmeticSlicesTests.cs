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
    public class _446_NumberOfArithmeticSlicesTests
    {
        [TestMethod()]
        public void NumberOfArithmeticSlicesTest()
        {
            int[] nums = new int[] { 2, 4, 6, 8, 10 };
            _446_NumberOfArithmeticSlices solution = new _446_NumberOfArithmeticSlices();
            Assert.AreEqual(7, solution.NumberOfArithmeticSlices(nums));
        }
    }
}