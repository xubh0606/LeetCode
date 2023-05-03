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
    public class _1588_SumOddLengthSubarraysTests
    {
        [TestMethod()]
        public void SumOddLengthSubarraysTest()
        {
            int[] arr = new int[] { 1, 4, 2, 5, 3 };
            _1588_SumOddLengthSubarrays solution = new _1588_SumOddLengthSubarrays();
            Assert.AreEqual(58, solution.SumOddLengthSubarrays(arr));
        }
    }
}