using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _463_IslandPerimeterTests
    {
        [TestMethod()]
        public void IslandPerimeterTest()
        {
            int[][] grid = ChangeStringToList.GetArrOfArrForInt("[[0, 1, 0, 0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]");
            _463_IslandPerimeter solution = new _463_IslandPerimeter();
            Assert.AreEqual(16, solution.IslandPerimeter(grid));
        }
    }
}