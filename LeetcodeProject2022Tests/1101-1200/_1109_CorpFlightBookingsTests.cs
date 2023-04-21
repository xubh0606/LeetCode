using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1101_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200.Tests
{
    [TestClass()]
    public class _1109_CorpFlightBookingsTests
    {
        [TestMethod()]
        public void CorpFlightBookingsTest()
        {
            int[][] bookings = ChangeStringToList.GetArrOfArrForInt("[[1, 2, 10],[2,3,20],[2,5,25]]");
            int n = 5;
            _1109_CorpFlightBookings solution = new _1109_CorpFlightBookings();
            Assert.AreEqual(5, solution.CorpFlightBookings(bookings, n).Length);
        }
    }
}