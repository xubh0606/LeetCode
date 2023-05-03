using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1401_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500.Tests
{
    [TestClass()]
    public class _1463_CherryPickupTests
    {
        [TestMethod()]
        public void CherryPickupTest()
        {
            int[][] grid = ChangeStringToList.GetArrOfArrForInt("[[3, 1, 1],[2, 5, 1],[1, 5, 5],[2, 1, 1]]");
            _1463_CherryPickup solution = new _1463_CherryPickup();
            Assert.AreEqual(24, solution.CherryPickup(grid));
        }
    }
}