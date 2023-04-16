using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _789_EscapeGhostsTests
    {
        [TestMethod()]
        public void EscapeGhostsTest()
        {
            int[][] ghosts = ChangeStringToList.GetArrOfArrForInt("[[1,9],[2,-5],[3,8],[9,8],[-1,3]]");
            int[] target = new int[] { 8, -10 };
            _789_EscapeGhosts solution = new _789_EscapeGhosts();
            Assert.IsFalse(solution.EscapeGhosts(ghosts, target));
        }
    }
}