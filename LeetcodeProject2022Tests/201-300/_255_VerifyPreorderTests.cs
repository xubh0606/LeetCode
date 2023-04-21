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
    public class _255_VerifyPreorderTests
    {
        [TestMethod()]
        public void VerifyPreorderTest()
        {
            int[] nums = new int[] {1, 3, 4, 2};
            _255_VerifyPreorder solution = new _255_VerifyPreorder();
            Assert.IsFalse(solution.VerifyPreorder(nums));
        }
    }
}