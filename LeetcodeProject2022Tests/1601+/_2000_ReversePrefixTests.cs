using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1601_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_.Tests
{
    [TestClass()]
    public class _2000_ReversePrefixTests
    {
        [TestMethod()]
        public void ReversePrefixTest()
        {
            string word = "abcdefd";
            char ch = 'd';
            _2000_ReversePrefix solution = new _2000_ReversePrefix();
            Assert.AreEqual("dcbaefd", solution.ReversePrefix(word, ch));
        }
    }
}