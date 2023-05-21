using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1401_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500.Tests
{
    [TestClass()]
    public class _1444_WaysTests
    {
        [TestMethod()]
        public void WaysTest()
        {
            string[] pizza = new string[] { "A..", "AAA", "..." };
            int k = 3;
            _1444_Ways solution = new _1444_Ways();
            Assert.AreEqual(3, solution.Ways(pizza, k));
        }

        [TestMethod()]
        public void WaysTest2()
        {
            string[] pizza = new string[] { "A..", "A..", "..." };
            int k = 1;
            _1444_Ways solution = new _1444_Ways();
            Assert.AreEqual(1, solution.Ways(pizza, k));
        }

        [TestMethod()]
        public void WaysTest3()
        {
            string[] pizza = new string[] { ".A", "AA", "A." };
            int k = 3;
            _1444_Ways solution = new _1444_Ways();
            Assert.AreEqual(3, solution.Ways(pizza, k));
        }
    }
}