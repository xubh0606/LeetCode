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
    public class _245_ShortestWordDistanceTests
    {
        [TestMethod()]
        public void ShortestWordDistanceTest()
        {
            string[] wordsDict = ChangeStringToList.GetStringArray(" [ practice ,  makes ,  perfect ,  coding ,  makes ]");
            _245_ShortestWordDistance solution = new _245_ShortestWordDistance();
            string word1 = "makes", word2 = "coding";
            Assert.AreEqual(1, solution.ShortestWordDistance(wordsDict, word1, word2));
        }
    }
}