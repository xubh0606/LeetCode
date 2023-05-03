using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _417_PacificAtlanticTests
    {
        [TestMethod()]
        public void PacificAtlanticTest()
        {
            int[][] heights = ChangeStringToList.GetArrOfArrForInt("[[1, 2, 2, 3, 5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]");
            _417_PacificAtlantic solution = new _417_PacificAtlantic();
            Assert.AreEqual(7, solution.PacificAtlantic(heights).Count);
        }
    }
}