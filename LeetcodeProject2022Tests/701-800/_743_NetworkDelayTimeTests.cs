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
    public class _743_NetworkDelayTimeTests
    {
        [TestMethod()]
        public void NetworkDelayTimeTest()
        {
            int[][] times = ChangeStringToList.GetArrOfArrForInt("[[2, 1, 1],[2, 3, 1],[3, 4, 1]]");
            int n = 4, k = 2;
            _743_NetworkDelayTime solution = new _743_NetworkDelayTime();
            Assert.AreEqual(2, solution.NetworkDelayTime(times, n, k));
        }
    }
}