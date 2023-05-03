using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _765_MinSwapsCouplesTests
    {
        [TestMethod()]
        public void MinSwapsCouplesTest()
        {
            int[] row = new int[] { 0, 2, 1, 3 };
            _765_MinSwapsCouples solution = new _765_MinSwapsCouples();
            Assert.AreEqual(1, solution.MinSwapsCouples(row));
        }
    }
}