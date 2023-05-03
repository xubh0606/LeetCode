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
    public class _863_DistanceKTests
    {
        [TestMethod()]
        public void DistanceKTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 5, 1, 6, 2, 0, 8, -1, -1, 7, 4 });
            int k = 2;
            _863_DistanceK solution = new _863_DistanceK();
            Assert.AreEqual(3, solution.DistanceK(root, root.left, k).Count);
        }
    }
}