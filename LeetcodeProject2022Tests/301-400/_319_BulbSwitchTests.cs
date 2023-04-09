using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _319_BulbSwitchTests
    {
        [TestMethod()]
        public void BulbSwitchTest()
        {
            _319_BulbSwitch solution = new _319_BulbSwitch();
            Assert.AreEqual(1, solution.BulbSwitch(3));
        }
    }
}