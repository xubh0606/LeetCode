using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1301_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1301_1400.Tests
{
    [TestClass()]
    public class _1363_LargestMultipleOfThreeTests
    {
        [TestMethod()]
        public void LargestMultipleOfThreeTest()
        {
            int[] digits = new int[] { 8, 6, 7, 1, 0 };
            _1363_LargestMultipleOfThree solution = new _1363_LargestMultipleOfThree();
            Assert.AreEqual("8760", solution.LargestMultipleOfThree(digits));
        }
    }
}