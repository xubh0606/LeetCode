using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1804_TrieTests
    {
        [TestMethod()]
        public void _1804_TrieTest()
        {
            _1804_Trie trie = new _1804_Trie();
            trie.Insert("apple");               // 插入 "apple"。
            trie.Insert("apple");               // 插入另一个 "apple"。
            trie.CountWordsEqualTo("apple");    // 有两个 "apple" 实例，所以返回 2。
            trie.CountWordsStartingWith("app"); // "app" 是 "apple" 的前缀，所以返回 2。
            trie.Erase("apple");                // 移除一个 "apple"。
            trie.CountWordsEqualTo("apple");    // 现在只有一个 "apple" 实例，所以返回 1。
            trie.CountWordsStartingWith("app"); // 返回 1
            trie.Erase("apple");                // 移除 "apple"。现在前缀树是空的。
            trie.CountWordsStartingWith("app"); // 返回 0
        }
    }
}