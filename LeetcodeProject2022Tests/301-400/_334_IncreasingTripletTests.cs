using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _334_IncreasingTripletTests
    {
        [TestMethod()]
        public void IncreasingTripletTest()
        {
            int[] nums = new int[]{1, 2, 3, 4, 5};
            _334_IncreasingTriplet solution = new _334_IncreasingTriplet();
            Assert.IsTrue(solution.IncreasingTriplet(nums));
        }
    }
}