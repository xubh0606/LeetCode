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
    public class _252_CanAttendMeetingsTests
    {
        [TestMethod()]
        public void CanAttendMeetingsTest()
        {
            int[][] intervals = ChangeStringToList.GetArrOfArrForInt("[[0, 30],[5,10],[15,20]]");
            _252_CanAttendMeetings solution = new _252_CanAttendMeetings();
            Assert.IsFalse(solution.CanAttendMeetings(intervals));
        }
    }
}