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
    public class _290_WordPatternTests
    {
        [TestMethod()]
        public void WordPatternTest()
        {
            string pattern = "abba", s = "dog cat cat dog";
            _290_WordPattern solution = new _290_WordPattern();
            Assert.IsTrue(solution.WordPattern(pattern, s));
        }
    }
}