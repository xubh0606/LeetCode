using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1001_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100.Tests
{
    [TestClass()]
    public class _1027_LongestArithSeqLengthTests
    {
        [TestMethod()]
        public void LongestArithSeqLengthTest()
        {
            int[] nums = new int[]{9, 4, 7, 2, 10};
            _1027_LongestArithSeqLength solution = new _1027_LongestArithSeqLength();
            Assert.AreEqual(3, solution.LongestArithSeqLength(nums));
        }
    }
}