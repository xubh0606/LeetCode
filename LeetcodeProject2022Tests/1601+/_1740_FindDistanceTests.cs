using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1601_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_.Tests
{
    [TestClass()]
    public class _1740_FindDistanceTests
    {
        [TestMethod()]
        public void FindDistanceTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] {3, 5, 1, 6, 2, 0, 8, -1, -1, 7, 4});
            int p = 5, q = 7;
            _1740_FindDistance solution = new _1740_FindDistance();
            Assert.AreEqual(2, solution.FindDistance(root, p, q));
        }
    }
}