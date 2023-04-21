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
    public class _526_CountArrangementTests
    {
        [TestMethod()]
        public void CountArrangementTest()
        {
            _526_CountArrangement solution = new _526_CountArrangement();
            Assert.AreEqual(2, solution.CountArrangement(2));
        }
    }
}