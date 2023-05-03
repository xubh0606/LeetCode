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
    public class _246_IsStrobogrammaticTests
    {
        [TestMethod()]
        public void IsStrobogrammaticTest()
        {
            string num = "69";
            _246_IsStrobogrammatic solution = new _246_IsStrobogrammatic();
            Assert.IsTrue(solution.IsStrobogrammatic(num));
        }
    }
}