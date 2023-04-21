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
    public class _827_LargestIslandTests
    {
        [TestMethod()]
        public void LargestIslandTest()
        {
            int[][] grid = ChangeStringToList.GetArrOfArrForInt("[[1, 0], [0, 1]]");
            _827_LargestIsland solution = new _827_LargestIsland();
            Assert.AreEqual(3, solution.LargestIsland(grid));
        }
    }
}