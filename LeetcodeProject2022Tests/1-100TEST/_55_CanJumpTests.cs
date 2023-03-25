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
    public class _55_CanJumpTests
    {
        [TestMethod()]
        public void CanJumpTest()
        {
            int[] nums = new int[] { 2, 3, 1, 1, 4 };
            _55_CanJump solution = new _55_CanJump();
            Assert.IsTrue(solution.CanJump(nums));
        }
    }
}