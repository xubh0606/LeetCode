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
    public class _576_FindPathsTests
    {
        [TestMethod()]
        public void FindPathsTest()
        {
            int m = 2, n = 2, maxMove = 2, startRow = 0, startColumn = 0;
            _576_FindPaths solution = new _576_FindPaths();
            Assert.AreEqual(6, solution.FindPaths(m, n, maxMove, startRow, startColumn));
        }
    }
}