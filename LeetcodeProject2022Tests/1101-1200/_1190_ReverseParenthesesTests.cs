using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1101_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200.Tests
{
    [TestClass()]
    public class _1190_ReverseParenthesesTests
    {
        [TestMethod()]
        public void ReverseParenthesesTest()
        {
            string s = "(u(love)i)";
            _1190_ReverseParentheses solution = new _1190_ReverseParentheses();
            Assert.AreEqual(6, solution.ReverseParentheses(s).Length);
        }
    }
}