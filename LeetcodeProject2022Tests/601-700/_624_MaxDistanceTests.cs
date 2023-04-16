using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._601_700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700.Tests
{
    [TestClass()]
    public class _624_MaxDistanceTests
    {
        [TestMethod()]
        public void MaxDistanceTest()
        {
            int[][] nums = ChangeStringToList.GetArrOfArrForInt("[[1,2,3],[4,5],[1,2,3]]");
            _624_MaxDistance solution = new _624_MaxDistance();
            Assert.AreEqual(4, solution.MaxDistance(nums));
        }
    }
}