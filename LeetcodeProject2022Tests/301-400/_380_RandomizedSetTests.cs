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
    public class _380_RandomizedSetTests
    {
        [TestMethod()]
        public void _380_RandomizedSetTest()
        {

            _380_RandomizedSet randomizedSet = new _380_RandomizedSet();
            Assert.IsTrue(randomizedSet.Insert(1)); // 向集合中插入 1 。返回 true 表示 1 被成功地插入。
            Assert.IsFalse(randomizedSet.Remove(2)); // 返回 false ，表示集合中不存在 2 。
            Assert.IsTrue(randomizedSet.Insert(2)); // 向集合中插入 2 。返回 true 。集合现在包含 [1,2] 。
            randomizedSet.GetRandom(); // getRandom 应随机返回 1 或 2 。
            Assert.IsTrue(randomizedSet.Remove(1)); // 从集合中移除 1 ，返回 true 。集合现在包含 [2] 。
            Assert.IsFalse(randomizedSet.Insert(2)); // 2 已在集合中，所以返回 false 。
            randomizedSet.GetRandom(); // 由于 2 是集合中唯一的数字，getRandom 总是返回 2 。
        }
    }
}