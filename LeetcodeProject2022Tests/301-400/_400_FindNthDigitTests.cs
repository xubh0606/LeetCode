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
    public class _400_FindNthDigitTests
    {
        [TestMethod()]
        public void FindNthDigitTest()
        {
            _400_FindNthDigit solution = new _400_FindNthDigit();
            Assert.AreEqual(0, solution.FindNthDigit(11));
        }
    }
}