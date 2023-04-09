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
    public class _551_CheckRecordTests
    {
        [TestMethod()]
        public void CheckRecordTest()
        {
            string s = "PPALLP";
            _551_CheckRecord solution = new _551_CheckRecord();
            Assert.IsTrue(solution.CheckRecord(s));
        }
    }
}