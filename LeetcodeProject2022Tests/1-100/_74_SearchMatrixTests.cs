using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _74_SearchMatrixTests
    {
        [TestMethod()]
        public void SearchMatrixTest()
        {
            int[][] matrix = ChangeStringToList.GetArrOfArrForInt("[[1, 3, 5, 7],[10,11,16,20],[23,30,34,60]]");
            int target = 3;
            _74_SearchMatrix solution = new _74_SearchMatrix();
            Assert.IsTrue(solution.SearchMatrix(matrix, target));
        }
    }
}