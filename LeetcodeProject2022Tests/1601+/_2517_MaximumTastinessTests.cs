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
    public class _2517_MaximumTastinessTests
    {
        [TestMethod()]
        public void MaximumTastinessTest()
        {
            int[] nums = new int[] { 34, 116, 83, 15, 150, 56, 69, 42, 26 };
            int k = 6;
            _2517_MaximumTastiness solution = new _2517_MaximumTastiness();
            Assert.AreEqual(19, solution.MaximumTastiness(nums, k));
        }
    }
}