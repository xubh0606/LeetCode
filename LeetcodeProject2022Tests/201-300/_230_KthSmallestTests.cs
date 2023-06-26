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
    public class _230_KthSmallestTests
    {
        [TestMethod()]
        public void KthSmallestTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 1, 4, -1, 2 });
            int k = 1;
            _230_KthSmallest solution = new _230_KthSmallest();
            Assert.AreEqual(1, solution.KthSmallest(root, k));
        }
    }
}