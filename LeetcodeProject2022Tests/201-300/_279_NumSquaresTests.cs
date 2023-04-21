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
    public class _279_NumSquaresTests
    {
        [TestMethod()]
        public void NumSquaresTest()
        {
            int n = 12;
            _279_NumSquares solution = new _279_NumSquares();
            Assert.AreEqual(3, solution.NumSquares(n));
        }
    }
}