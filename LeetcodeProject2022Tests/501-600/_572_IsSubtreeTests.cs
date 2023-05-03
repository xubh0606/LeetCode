using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _572_IsSubtreeTests
    {
        [TestMethod()]
        public void IsSubtreeTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 4, 5, 1, 2, -1, -1, -1, -1, 0 });
            TreeNode subRoot = TreeNode.GetTree(new int[] { 4, 1, 2 });
            _572_IsSubtree solution = new _572_IsSubtree();
            Assert.IsTrue(solution.IsSubtree(root, subRoot));
        }
    }
}