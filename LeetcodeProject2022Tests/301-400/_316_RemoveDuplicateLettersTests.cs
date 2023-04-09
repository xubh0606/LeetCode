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
    public class _316_RemoveDuplicateLettersTests
    {
        [TestMethod()]
        public void RemoveDuplicateLettersTest()
        {
            string s = "bcabc";
            _316_RemoveDuplicateLetters solution = new _316_RemoveDuplicateLetters();
            Assert.AreEqual("abc", solution.RemoveDuplicateLetters(s));
        }
    }
}