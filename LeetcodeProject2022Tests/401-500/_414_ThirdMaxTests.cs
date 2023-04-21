using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022Tests._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._401_500.Tests
{
    [TestClass()]
    public class _414_ThirdMaxTests
    {
        [TestMethod()]
        public void ThirdMaxTest()
        {
            int[] nums = new int[] { 3, 2, 1 };
            _414_ThirdMax solution = new _414_ThirdMax();
            Assert.AreEqual(1, solution.ThirdMax(nums));
        }
    }
}