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
    public class _253_MinMeetingRoomsTests
    {
        [TestMethod()]
        public void MinMeetingRoomsTest()
        {
            int[][] intervals = ChangeStringToList.GetArrOfArrForInt("[[0, 30],[5, 10],[15, 20]]");
            _253_MinMeetingRooms solution = new _253_MinMeetingRooms();
            Assert.AreEqual(2, solution.MinMeetingRooms(intervals));
        }
    }
}