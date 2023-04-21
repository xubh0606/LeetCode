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
    public class _490_HasPathTests
    {
        [TestMethod()]
        public void HasPathTest()
        {
            int[][]maze = ChangeStringToList.GetArrOfArrForInt("[[0, 0, 1, 0, 0],[0,0,0,0,0],[0,0,0,1,0],[1,1,0,1,1],[0,0,0,0,0]]");
            int[] start = new int[] { 0, 4 }, destination = new int[] { 4, 4 };
            _490_HasPath solution = new _490_HasPath();
            Assert.IsTrue(solution.HasPath(maze, start, destination));

        }
    }
}