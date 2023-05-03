using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._601_700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700.Tests
{
    [TestClass()]
    public class _621_LeastIntervalTests
    {
        [TestMethod()]
        public void LeastIntervalTest()
        {
            char[] tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' };
            int n = 2;
            _621_LeastInterval solution = new _621_LeastInterval();
            Assert.AreEqual(8, solution.LeastInterval(tasks, n));
        }
    }
}