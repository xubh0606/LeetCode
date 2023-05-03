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
    public class _2094_FindEvenNumbersTests
    {
        [TestMethod()]
        public void FindEvenNumbersTest()
        {
            int[] digits = new int[] { 2, 1, 3, 0 };
            _2094_FindEvenNumbers solution = new _2094_FindEvenNumbers();
            Assert.AreEqual(10, solution.FindEvenNumbers(digits).Length);
        }
    }
}