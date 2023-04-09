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
    public class _416_CanPartitionTests
    {
        [TestMethod()]
        public void CanPartitionTest()
        {
            int[] nums = new int[] { 1, 5, 11, 5 };
            _416_CanPartition solution = new _416_CanPartition();
            Assert.IsTrue(solution.CanPartition(nums));
        }
    }
}