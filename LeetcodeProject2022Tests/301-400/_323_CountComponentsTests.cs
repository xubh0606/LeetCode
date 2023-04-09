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
    public class _323_CountComponentsTests
    {
        [TestMethod()]
        public void CountComponentsTest()
        {
            int n = 5;
            int[][] edges = ChangeStringToList.GetArrOfArrForInt("[[0, 1], [1, 2], [3, 4]]");
            _323_CountComponents solution = new _323_CountComponents();
            Assert.AreEqual(2, solution.CountComponents(n, edges));
        }
    }
}