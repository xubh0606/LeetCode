using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _235_LowestCommonAncestorTests
    {
        [TestMethod()]
        public void LowestCommonAncestorTest()
        {
            TreeNode root = TreeNode.GetTree(new int[]{ 6, 2, 8, 0, 4, 7, 9, -1, -1, 3, 5});
            //p = 2, q = 4;
            _235_LowestCommonAncestor solution = new _235_LowestCommonAncestor();
            Assert.AreEqual(6, solution.LowestCommonAncestor(root, root.left, root.left.left).val);
        }
    }
}