using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _443_CompressTests
    {
        [TestMethod()]
        public void CompressTest()
        {
            char[] chars = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            char[] target = new char[] { 'a', '2', 'b', '2', 'c', '3', 'c' };
            _443_Compress solution = new _443_Compress();
            Assert.AreEqual(target.Length-1, solution.Compress(chars));
            for(int i = 0; i < target.Length; i++)
            {
                Assert.AreEqual(target[i], chars[i]);
            }
        }
    }
}