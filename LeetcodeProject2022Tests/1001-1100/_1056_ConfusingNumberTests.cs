using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1001_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100.Tests
{
    [TestClass()]
    public class _1056_ConfusingNumberTests
    {
        [TestMethod()]
        public void ConfusingNumberTest()
        {
            _1056_ConfusingNumber solution = new _1056_ConfusingNumber();
            Assert.IsTrue(solution.ConfusingNumber(6));
        }
    }
}