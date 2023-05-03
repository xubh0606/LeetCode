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
    public class _542_UpdateMatrixTests
    {
        [TestMethod()]
        public void UpdateMatrixTest()
        {
            int[][] mat = ChangeStringToList.GetArrOfArrForInt("[[0, 0, 0],[0,1,0],[0,0,0]]");
            _542_UpdateMatrix solution = new _542_UpdateMatrix();
            Assert.AreEqual(1, solution.UpdateMatrix(mat)[1][1]);
        }
    }
}