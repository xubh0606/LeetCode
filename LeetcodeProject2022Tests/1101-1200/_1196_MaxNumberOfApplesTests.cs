using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1101_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200.Tests
{
    [TestClass()]
    public class _1196_MaxNumberOfApplesTests
    {
        [TestMethod()]
        public void MaxNumberOfApplesTest()
        {
            int[] weight = new int[] { 100, 200, 150, 1000 };
            _1196_MaxNumberOfApples solution = new _1196_MaxNumberOfApples();
            Assert.AreEqual(4, solution.MaxNumberOfApples(weight));
        }
    }
}