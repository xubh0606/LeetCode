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
    public class _223_ComputeAreaTests
    {
        [TestMethod()]
        public void ComputeAreaTest()
        {
            int ax1 = -3, ay1 = 0, ax2 = 3, ay2 = 4, bx1 = 0, by1 = -1, bx2 = 9, by2 = 2;
            _223_ComputeArea solution = new _223_ComputeArea();
            Assert.AreEqual(45, solution.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2));
        }
    }
}