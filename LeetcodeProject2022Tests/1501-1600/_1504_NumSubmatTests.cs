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
    public class _1504_NumSubmatTests
    {
        [TestMethod()]
        public void NumSubmatTest()
        {
            int[][] mat = ChangeStringToList.GetArrOfArrForInt("[[1, 0, 1],[1,1,0],[1,1,0]]");
            _1504_NumSubmat solution = new _1504_NumSubmat();
            Assert.AreEqual(13, solution.NumSubmat(mat));
        }
    }
}