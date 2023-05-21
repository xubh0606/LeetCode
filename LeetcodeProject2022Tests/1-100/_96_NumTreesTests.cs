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
    public class _96_NumTreesTests
    {
        [TestMethod()]
        public void NumTreesTest()
        {
            _96_NumTrees solution = new _96_NumTrees();
            Assert.AreEqual(5, solution.NumTrees(3));
        }
    }
}