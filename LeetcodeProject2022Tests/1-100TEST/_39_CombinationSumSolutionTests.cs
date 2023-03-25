using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _39_CombinationSumSolutionTests
    {
        [TestMethod()]
        public void CombinationSumTest()
        {
            int[] candidate = new int[] { 2, 3, 6, 7 };
            int target = 7;
            _39_CombinationSumSolution solution = new _39_CombinationSumSolution();
            Assert.AreEqual(2, solution.CombinationSum(candidate, target).Count);
        }
    }
}