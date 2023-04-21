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
    public class _562_LongestLineTests
    {
        [TestMethod()]
        public void LongestLineTest()
        {
            int[][] mat = ChangeStringToList.GetArrOfArrForInt("[[0, 1, 1, 0],[0, 1, 1, 0],[0, 0, 0, 1]]");
            _562_LongestLine solution = new _562_LongestLine();
            Assert.AreEqual(3, solution.LongestLine(mat));
        }
    }
}