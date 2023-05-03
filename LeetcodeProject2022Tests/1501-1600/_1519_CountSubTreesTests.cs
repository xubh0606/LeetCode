using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1519_CountSubTreesTests
    {
        [TestMethod()]
        public void CountSubTreesTest()
        {
            int n = 7;
            int[][] edges = ChangeStringToList.GetArrOfArrForInt("[[0, 1],[0,2],[1,4],[1,5],[2,3],[2,6]]");
            string labels = "abaedcd";
            _1519_CountSubTrees solution = new _1519_CountSubTrees();
            //输出：[2,1,1,1,1,1,1]
            Assert.AreEqual(2, solution.CountSubTrees(n, edges, labels)[0]);
        }
    }
}