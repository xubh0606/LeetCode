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
    public class _208_TrieTests
    {
        [TestMethod()]
        public void _208_TrieTest()
        {

            _208_Trie trie = new _208_Trie();
            trie.Insert("apple");
            trie.Search("apple");   // 返回 True
            trie.Search("app");     // 返回 False
            trie.StartsWith("app"); // 返回 True
            trie.Insert("app");
            trie.Search("app");     // 返回 True
        }
    }
}