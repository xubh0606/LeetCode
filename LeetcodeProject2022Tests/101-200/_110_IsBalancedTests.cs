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
    public class _110_IsBalancedTests
    {
        [TestMethod()]
        public void IsBalancedTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 9, 20, -1, -1, 15, 7 });
            _110_IsBalanced solution = new _110_IsBalanced();
            Assert.IsTrue(solution.IsBalanced(root));
        }
    }
}