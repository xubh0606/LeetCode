using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._901_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000.Tests
{
    [TestClass()]
    public class _949_LargestTimeFromDigitsTests
    {
        [TestMethod()]
        public void LargestTimeFromDigitsTest()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            _949_LargestTimeFromDigits solution = new _949_LargestTimeFromDigits();
            Assert.AreEqual("23:41", solution.LargestTimeFromDigits(arr));
        }
    }
}