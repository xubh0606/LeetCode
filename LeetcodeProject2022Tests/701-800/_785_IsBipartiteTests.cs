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
    public class _785_IsBipartiteTests
    {
        [TestMethod()]
        public void IsBipartiteTest()
        {
            int[][] graph = ChangeStringToList.GetArrOfArrForInt("[[1, 2, 3],[0,2],[0,1,3],[0,2]]");
            _785_IsBipartite solution = new _785_IsBipartite();
            Assert.IsFalse(solution.IsBipartite(graph));
        }
    }
}