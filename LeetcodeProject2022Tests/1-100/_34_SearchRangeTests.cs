using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProject2022;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _34_SearchRangeTests
    {
        [TestMethod()]
        public void SearchRangeTest()
        {
            int[] nums = new int[]{1, 1, 1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6, 6, 6, 6, 9, 9, 9};
            _34_SearchRange solution = new _34_SearchRange();
            Assert.IsTrue(CompareToAnother.IsSameArrInt(new int[] { -1, -1 }, solution.SearchRange(nums, 7)));
        }
    }
}