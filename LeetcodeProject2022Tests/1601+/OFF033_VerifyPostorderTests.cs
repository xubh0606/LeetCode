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
    public class OFF033_VerifyPostorderTests
    {
        [TestMethod()]
        public void VerifyPostorderTest()
        {
            int[] nums = new int[] { 4, 6, 12, 8, 16, 14, 10 };
            OFF033_VerifyPostorder solution = new OFF033_VerifyPostorder();
            Assert.IsFalse(solution.VerifyPostorder(nums));
        }

        [TestMethod()]
        public void FindMidTest()
        {
            int[] nums = new int[] { 1, 3, 2, 6, 7 ,8,9,10 };
            OFF033_VerifyPostorder solution = new OFF033_VerifyPostorder();
            Assert.AreEqual(2, solution.FindMid(nums, 5, 0, 7));
        }
    }
}