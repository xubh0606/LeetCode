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
    public class _2148_CountElementsTests
    {
        [TestMethod()]
        public void CountElementsTest()
        {
            int[] nums = new int[] { 11, 7, 2, 15 };
            _2148_CountElements solution = new _2148_CountElements();
            Assert.AreEqual(2, solution.CountElements(nums));
        }
    }
}