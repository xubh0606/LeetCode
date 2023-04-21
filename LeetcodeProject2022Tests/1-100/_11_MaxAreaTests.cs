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
    public class _11_MaxAreaTests
    {
        [TestMethod()]
        public void MaxAreaTest()
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            _11_MaxArea solution = new _11_MaxArea();
            Assert.AreEqual(49, solution.MaxArea(height));
        }
    }
}