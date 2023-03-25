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
    public class LRUCacheTests
    {
        [TestMethod()]
        public void LRUCacheTest()
        {
            LRUCache lRUCache = new LRUCache(2);
            Assert.AreEqual(2, lRUCache.Get(0));
        }

        [TestMethod()]
        public void GetTest()
        {
            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(1, 1); // 缓存是 {1=1}
            lRUCache.Put(2, 2); // 缓存是 {1=1, 2=2}
            lRUCache.Get(1);    // 返回 1
        }

        [TestMethod()]
        public void PutTest()
        {
            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(1, 1); // 缓存是 {1=1}
            lRUCache.Put(2, 2); // 缓存是 {1=1, 2=2}
            lRUCache.Get(1);    // 返回 1
            lRUCache.Put(3, 3); // 该操作会使得关键字 2 作废，缓存是 {1=1, 3=3}
            lRUCache.Get(2);    // 返回 -1 (未找到)
            lRUCache.Put(4, 4); // 该操作会使得关键字 1 作废，缓存是 {4=4, 3=3}
            lRUCache.Get(1);    // 返回 -1 (未找到)
            lRUCache.Get(3);    // 返回 3
            lRUCache.Get(4);    // 返回 4
        }
    }
}