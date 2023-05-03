using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022Tests._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._1_100.Tests
{
    [TestClass()]
    public class _38_CountAndSayTests
    {
        [TestMethod()]
        public void CountAndSayTest()
        {
            _38_CountAndSay solution = new _38_CountAndSay();
            Assert.AreEqual("1211", solution.CountAndSay(4));
        }
    }
}