using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _150_EvalRPNTests
    {
        [TestMethod()]
        public void EvalRPNTest()
        {
            string[] tokens = new string[] { "2", "1", "+", "3", "*" };
            _150_EvalRPN solution = new _150_EvalRPN();
            Assert.AreEqual(9, solution.EvalRPN(tokens));
        }
    }
}