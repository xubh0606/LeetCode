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
    public class _45_JumpTests
    {
        [TestMethod()]
        public void JumpTest()
        {
            int[] nums = new int[] { 2, 3, 1, 1, 4 };
            _45_Jump solution = new _45_Jump();
            Assert.AreEqual(2, solution.Jump(nums));
        }
    }
}