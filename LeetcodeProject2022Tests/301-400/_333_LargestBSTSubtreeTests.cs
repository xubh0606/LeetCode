using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _333_LargestBSTSubtreeTests
    {
        [TestMethod()]
        public void LargestBSTSubtreeTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 10, 5, 15, 1, 8, -1, 7 });
            _333_LargestBSTSubtree solution = new _333_LargestBSTSubtree();
            Assert.AreEqual(3, solution.LargestBSTSubtree(root));
        }
    }
}