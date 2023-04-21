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
    public class _345_ReverseVowelsTests
    {
        [TestMethod()]
        public void ReverseVowelsTest()
        {
            string s = "hello";
            string target = "holle";
            _345_ReverseVowels solution = new _345_ReverseVowels();
            Assert.AreEqual(target, solution.ReverseVowels(s));
        }
    }
}