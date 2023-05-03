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
    public class _291_WordPatternMatchTests
    {
        [TestMethod()]
        public void WordPatternMatchTest()
        {
            string pattern = "abab", s = "redblueredblue";
            _291_WordPatternMatch solution = new _291_WordPatternMatch();
            Assert.IsTrue(solution.WordPatternMatch(pattern, s));
        }
    }
}