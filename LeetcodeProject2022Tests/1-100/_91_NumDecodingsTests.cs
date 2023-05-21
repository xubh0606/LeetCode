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
    public class _91_NumDecodingsTests
    {
        [TestMethod()]
        public void NumDecodingsTest()
        {
            string s = "10";
            _91_NumDecodings solution = new _91_NumDecodings();
            Assert.AreEqual(1, solution.NumDecodings(s));
        }
    }
}