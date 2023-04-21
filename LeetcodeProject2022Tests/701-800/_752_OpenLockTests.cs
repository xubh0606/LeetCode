using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _752_OpenLockTests
    {
        [TestMethod()]
        public void OpenLockTest()
        {
            string[] deadends = new string[] { "0201", "0101", "0102", "1212", "2002" };
            string target = "0202";
            _752_OpenLock solution = new _752_OpenLock();
            Assert.AreEqual(6, solution.OpenLock(deadends, target));
        }
    }
}