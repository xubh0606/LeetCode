using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._901_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000.Tests
{
    [TestClass()]
    public class _934_ShortestBridgeTests
    {
        [TestMethod()]
        public void ShortestBridgeTest()
        {
            int[][] grid = ChangeStringToList.GetArrOfArrForInt("[[0, 1],[1, 0]]");
            _934_ShortestBridge solution = new _934_ShortestBridge();
            Assert.AreEqual(1, solution.ShortestBridge(grid));
        }
    }
}