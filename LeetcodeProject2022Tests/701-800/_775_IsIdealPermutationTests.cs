using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _775_IsIdealPermutationTests
    {
        [TestMethod()]
        public void IsIdealPermutationTest()
        {
            int[] nums = new int[] { 1, 0, 2 };
            _775_IsIdealPermutation solution = new _775_IsIdealPermutation();
            Assert.IsTrue(solution.IsIdealPermutation(nums));
        }
    }
}