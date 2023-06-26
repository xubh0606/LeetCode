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
    public class _304_NumMatrixTests
    {
        [TestMethod()]
        public void _304_NumMatrixTest()
        {
            _304_NumMatrix numMatrix = new _304_NumMatrix(ChangeStringToList.GetArrOfArrForInt("[[3, 0, 1, 4, 2],[5, 6, 3, 2, 1],[1, 2, 0, 1, 5],[4, 1, 0, 1, 7],[1, 0, 3, 0, 5]]"));
            numMatrix.SumRegion(2, 1, 4, 3); // return 8 (红色矩形框的元素总和)
            numMatrix.SumRegion(1, 1, 2, 2); // return 11 (绿色矩形框的元素总和)
            numMatrix.SumRegion(1, 2, 2, 4); // return 12 (蓝色矩形框的元素总和)
        }
    }
}