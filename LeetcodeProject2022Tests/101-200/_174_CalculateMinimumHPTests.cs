using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _174_CalculateMinimumHPTests
    {
        [TestMethod()]
        public void CalculateMinimumHPTest()
        {
            int[][] dungeon = ChangeStringToList.GetArrOfArrForInt("[[-2 ,-3,3][- 5 ,-10, 1][10,  30, - 5]]");
            _174_CalculateMinimumHP solution = new _174_CalculateMinimumHP();
            Assert.AreEqual(7, solution.CalculateMinimumHP(dungeon));
        }
    }
}