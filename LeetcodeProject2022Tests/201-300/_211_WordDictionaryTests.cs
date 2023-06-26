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
    public class _211_WordDictionaryTests
    {
        [TestMethod()]
        public void _211_WordDictionaryTest()
        {
            _211_WordDictionary wordDictionary = new _211_WordDictionary();
            wordDictionary.AddWord("bad");
            wordDictionary.AddWord("dad");
            wordDictionary.AddWord("mad");
            wordDictionary.Search("pad"); // 返回 False
            wordDictionary.Search("bad"); // 返回 True
            wordDictionary.Search(".ad"); // 返回 True
            wordDictionary.Search("b.."); // 返回 True
        }
    }
}