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
    public class _1002_CommonCharsTests
    {
        [TestMethod()]
        public void CommonCharsTest()
        {
            string[] words = ChangeStringToList.GetStringArray("[ bella ,  label ,  roller ]");
            _1002_CommonChars solution = new _1002_CommonChars();
            Assert.AreEqual(3, solution.CommonChars(words).Count);
        }
    }
}