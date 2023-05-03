using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1601_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_.Tests
{
    [TestClass()]
    public class _1995_CountQuadrupletsTests
    {
        [TestMethod()]
        public void CountQuadrupletsTest()
        {
            int[] nums = new int[] { 1, 2, 3, 6 };
            _1995_CountQuadruplets solution = new _1995_CountQuadruplets();
            Assert.AreEqual(1, solution.CountQuadruplets(nums));
        }
    }
}