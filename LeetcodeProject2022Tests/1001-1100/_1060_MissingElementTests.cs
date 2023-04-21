using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1001_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100.Tests
{
    [TestClass()]
    public class _1060_MissingElementTests
    {
        [TestMethod()]
        public void MissingElementTest()
        {
            int[] nums = new int[] { 4, 7, 9, 10 };
            int k = 1;
            _1060_MissingElement solution = new _1060_MissingElement();
            Assert.AreEqual(5, solution.MissingElement(nums, k));
        }
    }
}