using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _200_NumIslandsTests
    {
        [TestMethod()]
        public void NumIslandsTest()
        {
            char[][] grid = ChangeStringToCharArr.GetCharArr("[[ 1 ,  1 ,  1 ,  1 ,  0 ],[ 1 ,  1,  0 ,  1 ,  0 ] [ 1  ,  1,  0 ,  0 ,  0 ][ 0 ,  0 ,  0 ,  0 ,  0 ]]");
            _200_NumIslands solution = new _200_NumIslands();
            Assert.AreEqual(1, solution.NumIslands(grid));
        }
    }
}