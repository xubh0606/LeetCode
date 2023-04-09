using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _552_CheckRecordTests
    {
        [TestMethod()]
        public void CheckRecordTest()
        {
            _552_CheckRecord solution = new _552_CheckRecord();
            Assert.AreEqual(183236316, solution.CheckRecord(10101));
        }
    }
}