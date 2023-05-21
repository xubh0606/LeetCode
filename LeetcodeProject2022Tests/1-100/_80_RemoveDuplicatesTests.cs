using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _80_RemoveDuplicatesTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            _80_RemoveDuplicates solution = new _80_RemoveDuplicates();
            Assert.AreEqual(5, solution.RemoveDuplicates(nums));
        }
    }
}