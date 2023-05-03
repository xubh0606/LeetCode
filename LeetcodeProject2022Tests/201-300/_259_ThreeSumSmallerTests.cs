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
    public class _259_ThreeSumSmallerTests
    {
        [TestMethod()]
        public void ThreeSumSmallerTest()
        {
            int[] nums = new int[] { -2, 0, 1, 3 };
            int target = 2;
            _259_ThreeSumSmaller solution = new _259_ThreeSumSmaller();
            Assert.AreEqual(2, solution.ThreeSumSmaller(nums, target));
        }
    }
}