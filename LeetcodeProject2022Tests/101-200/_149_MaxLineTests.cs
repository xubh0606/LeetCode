using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _149_MaxLineTests
    {
        [TestMethod()]
        public void MaxPointsTest()
        {
            string s = " [[1,1],[2,2],[3,3]]";
            ChangeStringToList changeArr = new ChangeStringToList();
            int[][] point = changeArr.GetArrOfArrForInt(s);
            _149_MaxLine solution = new _149_MaxLine();
            Assert.AreEqual(3, solution.MaxPoints(point));
        }
    }
}