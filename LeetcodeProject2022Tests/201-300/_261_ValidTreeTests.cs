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
    public class _261_ValidTreeTests
    {
        [TestMethod()]
        public void ValidTreeTest()
        {
            _261_ValidTree solution = new _261_ValidTree();
            int n = 5;
            int[][] edges = ChangeStringToList.GetArrOfArrForInt("[[0, 1],[0,2],[0,3],[1,4]]");
            Assert.IsTrue(solution.ValidTree(n, edges));
        }
    }
}