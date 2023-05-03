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
    public class _320_GenerateAbbreviationsTests
    {
        [TestMethod()]
        public void GenerateAbbreviationsTest()
        {
            string word = "word";
            _320_GenerateAbbreviations solution = new _320_GenerateAbbreviations();
            Assert.AreEqual(16, solution.GenerateAbbreviations(word).Count);
        }
    }
}