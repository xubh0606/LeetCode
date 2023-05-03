using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._901_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000.Tests
{
    [TestClass()]
    public class _912_SortArrayTests
    {
        [TestMethod()]
        public void SortArrayTest()
        {
            int[] nums = new int[] { 5, 1, 1, 2, 0, 0 };
            _912_SortArray solution = new _912_SortArray();
            Assert.AreEqual(0, solution.SortArray(nums)[0]);
        }
    }
}