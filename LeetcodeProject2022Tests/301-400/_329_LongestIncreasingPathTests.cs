using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _329_LongestIncreasingPathTests
    {
        [TestMethod()]
        public void LongestIncreasingPathTest()
        {
            int[][] matrix = ChangeStringToList.GetArrOfArrForInt("[[9, 9, 4],[6, 6, 8],[2, 1, 1]]");
            _329_LongestIncreasingPath solution = new _329_LongestIncreasingPath();
            Assert.AreEqual(4, solution.LongestIncreasingPath(matrix));
        }
    }
}