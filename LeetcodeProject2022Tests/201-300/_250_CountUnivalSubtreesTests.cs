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
    public class _250_CountUnivalSubtreesTests
    {
        [TestMethod()]
        public void CountUnivalSubtreesTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 5, 1, 5, 5, 5, -1, 5 });
            _250_CountUnivalSubtrees solution = new _250_CountUnivalSubtrees();
            Assert.AreEqual(4, solution.CountUnivalSubtrees(root));
        }
    }
}