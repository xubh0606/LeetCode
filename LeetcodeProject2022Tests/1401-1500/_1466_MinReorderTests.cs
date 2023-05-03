using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1401_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500.Tests
{
    [TestClass()]
    public class _1466_MinReorderTests
    {
        [TestMethod()]
        public void MinReorderTest()
        {
            int n = 5;
            int[][] connections = ChangeStringToList.GetArrOfArrForInt("[[1, 0],[1,2],[3,2],[3,4]]");
            _1466_MinReorder solution = new _1466_MinReorder();
            Assert.AreEqual(2, solution.MinReorder(n, connections));
        }
    }
}