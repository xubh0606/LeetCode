using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _171_TitleToNumberTests
    {
        [TestMethod()]
        public void TitleToNumberTest()
        {
            string columnTitle = "A";
            _171_TitleToNumber solution = new _171_TitleToNumber();
            Assert.AreEqual(1, solution.TitleToNumber(columnTitle));
        }
    }
}