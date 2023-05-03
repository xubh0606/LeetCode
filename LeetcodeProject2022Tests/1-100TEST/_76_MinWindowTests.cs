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
    public class _76_MinWindowTests
    {
        [TestMethod()]
        public void MinWindowTest()
        {
            string s = "ADOBECODEBANC", t = "ABC";
            _76_MinWindow solution = new _76_MinWindow();
            Assert.AreEqual("BANC", solution.MinWindow(s, t));
        }
    }
}