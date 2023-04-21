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
    public class _105_BuildTreeTests
    {
        [TestMethod()]
        public void BuildTreeTest()
        {
            int[] preorder = new int[] { 3, 9, 20, 15, 7 }, inorder = new int[] { 9, 3, 15, 20, 7 };
            TreeNode root = TreeNode.GetTree(new int[] { 3, 9, 20, -1, -1, 15, 7 });
            _105_BuildTree solution = new _105_BuildTree();
            Assert.IsTrue(TreeNode.IsSameTree(root, solution.BuildTree(preorder, inorder)));
        }
    }
}