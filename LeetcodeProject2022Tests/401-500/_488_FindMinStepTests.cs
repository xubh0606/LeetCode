using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _488_FindMinStepTests
    {
        [TestMethod()]
        public void FindMinStepTest()
        {
            string board = "WWRRBBWW", hand = "WRBRW";
            _488_FindMinStep solution = new _488_FindMinStep();
            Assert.AreEqual(2, solution.FindMinStep(board, hand));
        }
    }
}