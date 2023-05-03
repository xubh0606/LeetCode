using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _553_OptimalDivisionTests
    {
        [TestMethod()]
        public void OptimalDivisionTest()
        {
            int[] nums = new int[] { 1000, 100, 10, 2 };
            _553_OptimalDivision solution = new _553_OptimalDivision();
            Assert.AreEqual("1000/(100/10/2)", solution.OptimalDivision(nums));
        }
    }
}