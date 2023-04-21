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
    public class _243_ShortestDistanceTests
    {
        [TestMethod()]
        public void ShortestDistanceTest()
        {
            string[] wordsDict = ChangeStringToList.GetStringArray(" [ practice ,  makes ,  perfect ,  coding ,  makes ]");
            _243_ShortestDistance solution = new _243_ShortestDistance();
            string word1 = "makes", word2 = "coding";
            Assert.AreEqual(1, solution.ShortestDistance(wordsDict, word1, word2));
        }
    }
}