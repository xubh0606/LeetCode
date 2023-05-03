using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _844_BackspaceCompareTests
    {
        [TestMethod()]
        public void BackspaceCompareTest()
        {
            string s = "ab#c", t = "ad#c";
            _844_BackspaceCompare solution = new _844_BackspaceCompare();
            Assert.IsTrue(solution.BackspaceCompare(s, t));
        }
    }
}