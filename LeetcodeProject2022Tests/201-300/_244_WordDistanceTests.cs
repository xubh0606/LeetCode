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
    public class _244_WordDistanceTests
    {
        [TestMethod()]
        public void _244_WordDistanceTest()
        {
            _244_WordDistance wordDistance = new _244_WordDistance(ChangeStringToList.GetStringArray("[ practice ,  makes ,  perfect , coding ,  makes ]"));
            Assert.AreEqual(3, wordDistance.Shortest("coding", "practice")); // 返回 3
            Assert.AreEqual(1, wordDistance.Shortest("makes", "coding"));    // 返回 1
        }
    }
}