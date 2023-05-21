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
    public class _111_MinDepthTests
    {
        [TestMethod()]
        public void MinDepthTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 9, 20, -1, -1, 15, 7 });
            _111_MinDepth solution = new _111_MinDepth();
            Assert.AreEqual(2, solution.MinDepth(root));
        }
    }
}