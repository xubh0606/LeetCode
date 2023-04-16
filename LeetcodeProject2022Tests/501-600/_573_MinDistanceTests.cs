using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _573_MinDistanceTests
    {
        [TestMethod()]
        public void MinDistanceTest()
        {
            int height = 5, width = 7;
            int[] tree = new int[] { 2, 2 };
            int[] squirrel = new int[] { 4, 4 };
            int[][] nuts = ChangeStringToList.GetArrOfArrForInt("[[3,0], [2,5]]");
            _573_MinDistance solution = new _573_MinDistance();
            Assert.AreEqual(12, solution.MinDistance(height, width, tree, squirrel, nuts));
        }
    }
}