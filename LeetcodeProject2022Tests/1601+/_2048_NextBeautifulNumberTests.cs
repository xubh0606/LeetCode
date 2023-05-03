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
    public class _2048_NextBeautifulNumberTests
    {
        [TestMethod()]
        public void NextBeautifulNumberTest()
        {
            int n = 1000;
            _2048_NextBeautifulNumber solution = new _2048_NextBeautifulNumber();
            Assert.AreEqual(1333, solution.NextBeautifulNumber(n));
        }
    }
}