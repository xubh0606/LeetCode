using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _787_FindCheapestPriceTests
    {
        [TestMethod()]
        public void FindCheapestPriceTest()
        {
            int n = 3, src = 0, dst = 2, k = 1;
            int[][] edges = ChangeStringToList.GetArrOfArrForInt("[[0, 1, 100],[1,2,100],[0,2,500]]");
            _787_FindCheapestPrice solution = new _787_FindCheapestPrice();
            Assert.AreEqual(800, solution.FindCheapestPrice(n, edges, src, dst, k));
        }
    }
}