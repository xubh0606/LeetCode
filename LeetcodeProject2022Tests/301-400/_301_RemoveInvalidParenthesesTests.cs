using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _301_RemoveInvalidParenthesesTests
    {
        [TestMethod()]
        public void RemoveInvalidParenthesesTest()
        {
            string s = "()())()";
            _301_RemoveInvalidParentheses solution = new _301_RemoveInvalidParentheses();
            Assert.AreEqual(2, solution.RemoveInvalidParentheses(s).Count);
        }

        [TestMethod()]
        public void RemoveInvalidParenthesesTest2()
        {
            string s = ")(";
            _301_RemoveInvalidParentheses solution = new _301_RemoveInvalidParentheses();
            Assert.AreEqual(2, solution.RemoveInvalidParentheses(s).Count);
        }
    }
}