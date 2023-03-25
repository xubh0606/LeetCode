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
    public class _124_MaxPathSumTests
    {
        [TestMethod()]
        public void MaxPathSumTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] {-10, 9, 20, -1, -1, 15, 7});
            _124_MaxPathSum solution = new _124_MaxPathSum();
            Assert.AreEqual(42, solution.MaxPathSum(root));
        }
    }
}