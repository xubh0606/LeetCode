using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1301_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1301_1400.Tests
{
    [TestClass()]
    public class _1391_HasValidPathTests
    {
        [TestMethod()]
        public void HasValidPathTest()
        {
            int[][] grid = ChangeStringToList.GetArrOfArrForInt("[[2, 4, 3],[6, 5, 2]]");
            _1391_HasValidPath solution = new _1391_HasValidPath();
            Assert.IsTrue(solution.HasValidPath(grid));
        }
    }
}