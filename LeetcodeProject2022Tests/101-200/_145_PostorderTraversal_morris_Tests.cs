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
    public class _145_PostorderTraversal_morris_Tests
    {
        [TestMethod()]
        public void PostorderTraversalTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, -1, 2, 3 });
            _145_PostorderTraversal solution = new _145_PostorderTraversal();
            Assert.AreEqual(3, solution.PostorderTraversal(root));
        }
    }
}