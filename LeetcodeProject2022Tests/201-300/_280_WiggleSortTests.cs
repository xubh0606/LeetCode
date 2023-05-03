using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _280_WiggleSortTests
    {
        [TestMethod()]
        public void WiggleSortTest()
        {
            int[] nums = new int[] { 3, 5, 2, 1, 6, 4 };
            int[] target = new int[] { 3, 5, 1, 6, 2, 4 };
            _280_WiggleSort solution = new _280_WiggleSort();
            solution.WiggleSort(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                Assert.AreEqual(nums[i], target[i]);
            }
        }
    }
}