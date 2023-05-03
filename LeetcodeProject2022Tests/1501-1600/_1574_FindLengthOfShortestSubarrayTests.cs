using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1574_FindLengthOfShortestSubarrayTests
    {
        [TestMethod()]
        public void FindLengthOfShortestSubarrayTest()
        {
            int[] arr = new int[] {1, 2, 3, 10, 0, 7, 8, 9};
            _1574_FindLengthOfShortestSubarray solution = new _1574_FindLengthOfShortestSubarray();
            Assert.AreEqual(2, solution.FindLengthOfShortestSubarray(arr));
        }
    }
}