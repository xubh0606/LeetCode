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
    public class _1660_CorrectBinaryTreeTests
    {
        [TestMethod()]
        public void CorrectBinaryTreeTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 8, 3, 1, 7, -1, 9, 4, 2, -1, -1, -1, 5, 6 });
            int fromNode = 7, toNode = 4;
            _1660_CorrectBinaryTree solution = new _1660_CorrectBinaryTree();
            Assert.AreEqual(8, solution.CorrectBinaryTree(root).val);
        }
    }
}