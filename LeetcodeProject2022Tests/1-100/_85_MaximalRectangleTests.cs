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
    public class _85_MaximalRectangleTests
    {
        [TestMethod()]
        public void MaximalRectangleTest()
        {
            char[][] matrix = ChangeStringToCharArr.GetCharArr("[[ 1 ,  0 ,  1 ,  0 ,  0 ],[ 1 ,  0 ,  1 ,  1 ,  1 ],[ 1 ,  1 ,  1 ,  1 ,  1 ],[ 1 ,  0 ,  0 ,  1 ,  0 ]]");
            _85_MaximalRectangle solution = new _85_MaximalRectangle();
            Assert.AreEqual(6, solution.MaximalRectangle(matrix));
        }
    }
}