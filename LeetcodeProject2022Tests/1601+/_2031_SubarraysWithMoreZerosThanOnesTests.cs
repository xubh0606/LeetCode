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
    public class _2031_SubarraysWithMoreZerosThanOnesTests
    {
        [TestMethod()]
        public void SubarraysWithMoreZerosThanOnesTest()
        {
            int[] nums = new int[] { 0, 1, 1, 0, 1 };
            _2031_SubarraysWithMoreZerosThanOnes solution = new _2031_SubarraysWithMoreZerosThanOnes();
            Assert.AreEqual(9, solution.SubarraysWithMoreZerosThanOnes(nums));
        }
    }
}