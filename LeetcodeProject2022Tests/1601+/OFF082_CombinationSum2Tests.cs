using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022Tests._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._1501_1600.Tests
{
    [TestClass()]
    public class OFF082_CombinationSum2Tests
    {
        [TestMethod()]
        public void CombinationSum2Test()
        {
            int[] candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;
            OFF082_CombinationSum2 solution = new OFF082_CombinationSum2();
            Assert.AreEqual(4, solution.CombinationSum2(candidates, target).Count);
        }
    }
}