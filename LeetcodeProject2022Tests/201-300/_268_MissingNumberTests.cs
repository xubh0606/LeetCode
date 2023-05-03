using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _268_MissingNumberTests
    {
        [TestMethod()]
        public void MissingNumberTest()
        {
            int[] nums = new int[]{3, 0, 1};
            _268_MissingNumber solution = new _268_MissingNumber();
            Assert.AreEqual(2, solution.MissingNumber(nums));
        }
    }
}