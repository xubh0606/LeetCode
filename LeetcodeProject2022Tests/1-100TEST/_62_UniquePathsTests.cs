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
    public class _62_UniquePathsTests
    {
        [TestMethod()]
        public void UniquePathsTest()
        {
            _62_UniquePaths solution = new _62_UniquePaths();
            Assert.AreEqual(28, solution.UniquePaths(3, 7));
        }
    }
}