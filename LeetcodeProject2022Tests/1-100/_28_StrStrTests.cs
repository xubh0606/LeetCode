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
    public class _28_StrStrTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            string haystack = "sadbutsad", needle = "sad";
            _28_StrStr solution = new _28_StrStr();
            Assert.AreEqual(0, solution.StrStr(haystack, needle));
        }
    }
}