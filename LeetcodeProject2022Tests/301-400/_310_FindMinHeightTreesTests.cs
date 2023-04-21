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
    public class _310_FindMinHeightTreesTests
    {
        [TestMethod()]
        public void FindMinHeightTreesTest()
        {
            int n = 4;
            int[][] edges = ChangeStringToList.GetArrOfArrForInt("[[1, 0],[1,2],[1,3]]");
            _310_FindMinHeightTrees solution = new _310_FindMinHeightTrees();
            Assert.AreEqual(1, solution.FindMinHeightTrees(n, edges)[0]);
        }
    }
}