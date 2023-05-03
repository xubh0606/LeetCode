using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1540_CanConvertStringTests
    {
        [TestMethod()]
        public void CanConvertStringTest()
        {
            string s = "input", t = "ouput";
            int k = 9;
            _1540_CanConvertString solution = new _1540_CanConvertString();
            Assert.IsTrue(solution.CanConvertString(s, t, k));
        }
    }
}