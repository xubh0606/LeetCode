using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._601_700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700.Tests
{
    [TestClass()]
    public class _675_CutOffTreeTests
    {
        [TestMethod()]
        public void CutOffTreeTest()
        {
            int[][] forest = ChangeStringToList.GetArrOfArrForInt("[[1, 2, 3],[0,0,4],[7,6,5]]");
            _675_CutOffTree solution = new _675_CutOffTree();
            Assert.AreEqual(6, solution.CutOffTree(forest));
        }
    }
}