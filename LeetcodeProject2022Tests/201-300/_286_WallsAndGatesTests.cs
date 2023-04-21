using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _286_WallsAndGatesTests
    {
        [TestMethod()]
        public void WallsAndGatesTest()
        {
            int[][] rooms = ChangeStringToList.GetArrOfArrForInt("[[2147483647, -1, 0, 2147483647],[2147483647, 2147483647, 2147483647, -1],[2147483647, -1, 2147483647, -1],[0, -1, 2147483647, 2147483647]]");
            _286_WallsAndGates solution = new _286_WallsAndGates();
            solution.WallsAndGates(rooms);
            Assert.AreEqual(3, rooms[0][0]);
        }
    }
}