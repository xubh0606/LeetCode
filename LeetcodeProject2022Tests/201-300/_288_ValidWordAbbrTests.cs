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
    public class _288_ValidWordAbbrTests
    {
        [TestMethod()]
        public void _288_ValidWordAbbrTest()
        {

            _288_ValidWordAbbr validWordAbbr = new _288_ValidWordAbbr(ChangeStringToList.GetStringArray("[ deer ,  door ,  cake ,  card ]"));
            Assert.IsFalse( validWordAbbr.IsUnique("dear")); // 返回 false，字典中的 "deer" 与输入 "dear" 的缩写都是 "d2r"，但这两个单词不相同
            Assert.IsTrue(validWordAbbr.IsUnique("cart")); // 返回 true，字典中不存在缩写为 "c2t" 的单词
            Assert.IsFalse(validWordAbbr.IsUnique("cane")); // 返回 false，字典中的 "cake" 与输入 "cane" 的缩写都是 "c2e"，但这两个单词不相同
            Assert.IsTrue(validWordAbbr.IsUnique("make")); // 返回 true，字典中不存在缩写为 "m2e" 的单词
            Assert.IsTrue(validWordAbbr.IsUnique("cake")); // 返回 true，因为 "cake" 已经存在于字典中，并且字典中没有其他缩写为 "c2e" 的单词

        }
    }
}