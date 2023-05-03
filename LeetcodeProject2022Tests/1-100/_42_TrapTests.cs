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
    public class _42_TrapTests
    {
        [TestMethod()]
        public void TrapTest()
        {
            int[] height = new int[]{0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
            _42_Trap solution = new _42_Trap();
            Assert.AreEqual(6, solution.Trap(height));
        }
    }
}