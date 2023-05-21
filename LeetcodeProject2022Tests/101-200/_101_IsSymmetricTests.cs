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
    public class _101_IsSymmetricTests
    {
        [TestMethod()]
        public void IsSymmetricTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, 2, 2, 3, 4, 4, 3 });
            _101_IsSymmetric solution = new _101_IsSymmetric();
            Assert.IsTrue(solution.IsSymmetric(root));
        }
    }
}