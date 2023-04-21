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
    public class _179_LargestNumberTests
    {
        [TestMethod()]
        public void LargestNumberTest()
        {
            int[] nums = new int[] { 3, 30, 34, 5, 9 };
            _179_LargestNumber solution = new _179_LargestNumber();
            Assert.AreEqual("9534330", solution.LargestNumber(nums));
        }
    }
}