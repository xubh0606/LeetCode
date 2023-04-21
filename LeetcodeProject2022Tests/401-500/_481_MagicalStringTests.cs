using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _481_MagicalStringTests
    {
        [TestMethod()]
        public void MagicalStringTest()
        {
            _481_MagicalString solution = new _481_MagicalString();
            Assert.AreEqual(3, solution.MagicalString(6));
        }
    }
}