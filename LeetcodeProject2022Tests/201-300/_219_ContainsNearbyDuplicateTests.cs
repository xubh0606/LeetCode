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
    public class _219_ContainsNearbyDuplicateTests
    {
        [TestMethod()]
        public void ContainsNearbyDuplicateTest()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            int k = 3;
            _219_ContainsNearbyDuplicate solution = new _219_ContainsNearbyDuplicate();
            Assert.IsTrue(solution.ContainsNearbyDuplicate(nums, k));
        }
    }
}