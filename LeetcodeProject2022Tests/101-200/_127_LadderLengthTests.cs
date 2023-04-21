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
    public class _127_LadderLengthTests
    {
        [TestMethod()]
        public void LadderLengthTest()
        {
            string beginWord = "hit", endWord = "cog";
            string[] wordList = new string[] { "hot", "dot", "dog", "lot", "log", "cog" };
            _127_LadderLength solution = new _127_LadderLength();
            Assert.AreEqual(5, solution.LadderLength(beginWord, endWord, wordList));
        }
    }
}