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
    public class _276_NumWaysTests
    {
        [TestMethod()]
        public void NumWaysTest()
        {
            _276_NumWays solution = new _276_NumWays();
            int n = 3, k = 2;
            Assert.AreEqual(6, solution.NumWays(n, k));
        }
    }
}