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
    public class _886_PossibleBipartitionTests
    {
        [TestMethod()]
        public void PossibleBipartitionTest()
        {
            int n = 4;
            int[][] dislikes = ChangeStringToList.GetArrOfArrForInt("[[1, 2],[1,3],[2,4]]");
            _886_PossibleBipartition solution = new _886_PossibleBipartition();
            Assert.IsTrue(solution.PossibleBipartition(n, dislikes));
        }
    }
}