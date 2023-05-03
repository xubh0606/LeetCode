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
    public class _1594_MaxProductPathTests
    {
        [TestMethod()]
        public void MaxProductPathTest()
        {
            int[][] grid = new int[][] { new int[] { -1, -2, -3 }, new int[] { -2, -3, -3 }, new int[] { -3, -3, -2 } };
            _1594_MaxProductPath solution = new _1594_MaxProductPath();
            Assert.AreEqual(-1, solution.MaxProductPath(grid));
        }
    }
}