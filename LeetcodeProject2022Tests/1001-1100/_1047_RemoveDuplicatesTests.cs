using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1001_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100.Tests
{
    [TestClass()]
    public class _1047_RemoveDuplicatesTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            string s = "abbaca";
            _1047_RemoveDuplicates solution = new _1047_RemoveDuplicates();
            Assert.AreEqual("ca", solution.RemoveDuplicates(s));
        }
    }
}