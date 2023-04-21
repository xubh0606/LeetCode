using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _70_ClimbStairsTests
    {
        [TestMethod()]
        public void ClimbStairsTest()
        {
            _70_ClimbStairs solution = new _70_ClimbStairs();
            Assert.AreEqual(3, solution.ClimbStairs(3));
        }
    }
}