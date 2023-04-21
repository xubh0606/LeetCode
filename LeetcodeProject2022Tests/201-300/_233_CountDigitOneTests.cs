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
    public class _233_CountDigitOneTests
    {
        [TestMethod()]
        public void CountDigitOneTest()
        {
            _233_CountDigitOne solution = new _233_CountDigitOne();
            Assert.AreEqual(6, solution.CountDigitOne(13));
        }
    }
}