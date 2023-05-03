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
    public class _418_WordsTypingTests
    {
        [TestMethod()]
        public void WordsTypingTest()
        {
            int rows = 2, cols = 8;
            string[] sentence = new string[] { "hello", "world" };
            _418_WordsTyping solution = new _418_WordsTyping();
            Assert.AreEqual(1, solution.WordsTyping(sentence, rows, cols));
        }
    }
}