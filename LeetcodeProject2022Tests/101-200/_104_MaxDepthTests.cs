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
    public class _104_MaxDepthTests
    {
        [TestMethod()]
        public void MaxDepthTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 9, 20, -1, -1, 15, 7 });
            _104_MaxDepth solution = new _104_MaxDepth();
            Assert.AreEqual(3, solution.MaxDepth(root));
        }
    }
}