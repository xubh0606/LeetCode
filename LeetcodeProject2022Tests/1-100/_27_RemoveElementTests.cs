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
    public class _27_RemoveElementTests
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            int[] nums = new int[] { 3, 2, 2, 3 };
            int val = 3;
            _27_RemoveElement solution = new _27_RemoveElement();
            Assert.AreEqual(2, solution.RemoveElement(nums, val));
        }
    }
}