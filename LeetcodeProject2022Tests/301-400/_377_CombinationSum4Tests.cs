using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _377_CombinationSum4Tests
    {
        [TestMethod()]
        public void CombinationSum4Test()
        {
            int[] nums = new int[] { 1, 2, 3 };
            int target = 4;
            _377_CombinationSum4 solution = new _377_CombinationSum4();
            Assert.AreEqual(7, solution.CombinationSum4(nums, target));
        }
    }
}