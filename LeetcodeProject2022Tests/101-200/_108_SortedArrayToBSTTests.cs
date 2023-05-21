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
    public class _108_SortedArrayToBSTTests
    {
        [TestMethod()]
        public void SortedArrayToBSTTest()
        {
            int[] nums = new int[] { -10, -3, 0, 5, 9 };
            _108_SortedArrayToBST solution = new _108_SortedArrayToBST();
            Assert.AreEqual(0, solution.SortedArrayToBST(nums).val);
        }
    }
}