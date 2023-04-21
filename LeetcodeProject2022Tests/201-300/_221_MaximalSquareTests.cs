using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _221_MaximalSquareTests
    {
        [TestMethod()]
        public void MaximalSquareTest()
        {
            char[][] matrix = ChangeStringToCharArr.GetCharArr("[[ 1 ,  0 ,  1 ,  0 ,  0 ],[ 1 , 0 , 1 , 1 , 1 ],[ 1 , 1 , 1 , 1 , 1 ],[ 1 , 0 , 0 , 1 , 0 ]]");
            _221_MaximalSquare solution = new _221_MaximalSquare();
            Assert.AreEqual(4, solution.MaximalSquare(matrix));
        }
    }
}