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
    public class _95__GenerateTreesTests
    {
        [TestMethod()]
        public void GenerateTreesTest()
        {
            int n = 3;
            _95__GenerateTrees solution = new _95__GenerateTrees();
            Assert.AreEqual(5, solution.GenerateTrees(n).Count);
        }
    }
}