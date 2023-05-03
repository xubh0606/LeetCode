using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _841_CanVisitAllRoomsTests
    {
        [TestMethod()]
        public void CanVisitAllRoomsTest()
        {
            int[][] rooms = ChangeStringToList.GetArrOfArrForInt("[[1],[2],[3],[]]");
            _841_CanVisitAllRooms solution = new _841_CanVisitAllRooms();
            Assert.IsTrue(solution.CanVisitAllRooms(rooms));
        }
    }
}