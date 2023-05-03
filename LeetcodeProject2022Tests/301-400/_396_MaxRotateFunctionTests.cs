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
    public class _396_MaxRotateFunctionTests
    {
        [TestMethod()]
        public void MaxRotateFunctionTest()
        {
            int[] nums = new int[] { 4, 3, 2, 6 };
            _396_MaxRotateFunction solution = new _396_MaxRotateFunction();
            Assert.AreEqual(26, solution.MaxRotateFunction(nums));
        }
    }
}