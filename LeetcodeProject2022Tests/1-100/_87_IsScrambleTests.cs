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
    public class _87_IsScrambleTests
    {
        [TestMethod()]
        public void IsScrambleTest()
        {
            string s1 = "abcd", s2 = "bcad";
            _87_IsScramble solution = new _87_IsScramble();
            Assert.IsTrue(solution.IsScramble(s1, s2));
        }
    }
}