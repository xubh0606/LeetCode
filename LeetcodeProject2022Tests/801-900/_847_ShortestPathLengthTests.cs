using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _847_ShortestPathLengthTests
    {
        [TestMethod()]
        public void ShortestPathLengthTest()
        {
            int[][] graph = ChangeStringToList.GetArrOfArrForInt("[[1, 2, 3],[0],[0],[0]]");
            _847_ShortestPathLength solution = new _847_ShortestPathLength();
            Assert.AreEqual(4, solution.ShortestPathLength(graph));
        }
    }
}