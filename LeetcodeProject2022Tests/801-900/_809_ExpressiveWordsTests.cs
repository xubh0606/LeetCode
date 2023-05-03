using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _809_ExpressiveWordsTests
    {
        [TestMethod()]
        public void ExpressiveWordsTest()
        {
            string s = "heeellooo";
            string[] words = new string[] { "hello", "hi", "helo" };
            _809_ExpressiveWords solution = new _809_ExpressiveWords();
            Assert.AreEqual(1, solution.ExpressiveWords(s, words));
        }
    }
}