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
    public class _217_ContainsDuplicateTests
    {
        [TestMethod()]
        public void ContainsDuplicateTest()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            _217_ContainsDuplicate solution = new _217_ContainsDuplicate();
            Assert.IsTrue(solution.ContainsDuplicate(nums));
        }
    }
}