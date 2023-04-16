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
    public class _778_SwimInWaterTests
    {
        [TestMethod()]
        public void SwimInWaterTest()
        {
            int[][] grid = ChangeStringToList.GetArrOfArrForInt("[[0, 2],[1, 3]]");
            _778_SwimInWater solution = new _778_SwimInWater();
            Assert.AreEqual(3, solution.SwimInWater(grid));
        }
    }
}