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
    public class _954_CanReorderDoubledTests
    {
        [TestMethod()]
        public void CanReorderDoubledTest()
        {
            int[] arr = new int[] { 3, 1, 3, 6 };
            _954_CanReorderDoubled solution = new _954_CanReorderDoubled();
            Assert.IsFalse(solution.CanReorderDoubled(arr));
        }
    }
}