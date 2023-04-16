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
    public class _662_WidthOfBinaryTreeTests
    {
        [TestMethod()]
        public void WidthOfBinaryTreeTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, 3, 2, 5, -1, -1, 9, 6, -1, 7 });
            _662_WidthOfBinaryTree solution = new _662_WidthOfBinaryTree();
            Assert.AreEqual(7, solution.WidthOfBinaryTree(root));
        }
    }
}