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
    public class _299_bulls_and_cowsTests
    {
        [TestMethod()]
        public void GetHintTest()
        {
            string secret = "1807", guess = "7810";
            _299_bulls_and_cows solution = new _299_bulls_and_cows();
            Assert.AreEqual("1A3B", solution.GetHint(secret, guess));
        }
    }
}