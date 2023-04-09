using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _376_WiggleMaxLengthTests
    {
        [TestMethod()]
        public void WiggleMaxLengthTest()
        {
            int[] nums = new int[]{1, 7, 4, 9, 2, 5};
            _376_WiggleMaxLength solution = new _376_WiggleMaxLength();
            Assert.AreEqual(6, solution.WiggleMaxLength(nums));
        }
    }
}