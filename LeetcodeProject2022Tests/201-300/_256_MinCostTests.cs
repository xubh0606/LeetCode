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
    public class _256_MinCostTests
    {
        [TestMethod()]
        public void MinCostTest()
        {
            int[][] costs = ChangeStringToList.GetArrOfArrForInt("[[17, 2, 17],[16,16,5],[14,3,19]]");
            _256_MinCost solution = new _256_MinCost();
            Assert.AreEqual(10, solution.MinCost(costs));
        }
    }
}