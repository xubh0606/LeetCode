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
    public class _222_CountNodesTests
    {
        [TestMethod()]
        public void CountNodesTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, 2, 3, 4, 5, 6 });
            _222_CountNodes solution = new _222_CountNodes();
            Assert.AreEqual(6, solution.CountNodes(root));
        }
    }
}