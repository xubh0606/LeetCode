using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _381_RandomizedCollectionTests
    {
        [TestMethod()]
        public void _381_RandomizedCollectionTest()
        {

            _381_RandomizedCollection collection = new _381_RandomizedCollection();// 初始化一个空的集合。
            //["RandomizedCollection","insert","insert","insert","insert","insert",
            //"remove","remove","remove","insert","remove",
            //"getRandom","getRandom","getRandom","getRandom","getRandom",
            //"getRandom","getRandom","getRandom","getRandom","getRandom"]
            //[[],[1],[1],[2],[2],[2],[1],[1],[2],[1],[2],[],[],[],[],[],[],[],[],[],[]]
            collection.Insert(1);   // 返回 true，因为集合不包含 1。
                                    // 将 1 插入到集合中。
            collection.Insert(1);   // 返回 false，因为集合包含 1。
                                    // 将另一个 1 插入到集合中。集合现在包含 [1,1]。
            collection.Insert(2);   // 返回 true，因为集合不包含 2。
                                    // 将 2 插入到集合中。集合现在包含 [1,1,2]。
            collection.Insert(2);   // 返回 true，因为集合不包含 2。
                                    // 将 2 插入到集合中。集合现在包含 [1,1,2,2]。
            collection.Insert(2);   // 返回 true，因为集合不包含 2。
                                    // 将 2 插入到集合中。集合现在包含 [1,1,2,2,2]。
            collection.Remove(1);   // 返回 true，因为集合包含 1。
                                    // 从集合中移除 1。集合现在包含 [1,2,2,2]。
            collection.Remove(1);   // 返回 true，因为集合包含 1。
                                    // 从集合中移除 1。集合现在包含 [2,2,2]。
            collection.Remove(2);   // 返回 true，因为集合包含 1。
                                    // 从集合中移除 1。集合现在包含 [2,2]。
            collection.Insert(1);   // 返回 false，因为集合不包含 1。
                                    // 从集合中插入 1。集合现在包含 [1,2，2]。
            collection.Remove(2);   // 返回 true，因为集合包含 2。
                                    // 从集合中移除 1。集合现在包含 [1,2]。
            collection.GetRandom(); // getRandom 应该返回 1 或 2，两者的可能性相同。
            collection.GetRandom(); // getRandom 应该返回 1 或 2，两者的可能性相同。
        }
    }
}