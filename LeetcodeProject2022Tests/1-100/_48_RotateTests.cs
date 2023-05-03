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
    public class _48_RotateTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            int[][] matrix = ChangeStringToList.GetArrOfArrForInt("[[1, 2, 3],[4, 5, 6],[7, 8, 9]]");
            _48_Rotate solution = new _48_Rotate();
            solution.Rotate(matrix);
            Assert.AreEqual(7, matrix[0][0]);
        }
    }
}