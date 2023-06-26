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
    public class _151_ReverseWordsTests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            string s = "the sky is blue";
            _151_ReverseWords solution = new _151_ReverseWords();
            Assert.AreEqual("blue is sky the", solution.ReverseWords(s));
        }
    }
}