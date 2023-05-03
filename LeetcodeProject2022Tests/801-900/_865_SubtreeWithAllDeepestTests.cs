using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _865_SubtreeWithAllDeepestTests
    {
        [TestMethod()]
        public void SubtreeWithAllDeepestTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 5, 1, 6, 2, 0, 8, -1, -1, 7, 4 });
            _865_SubtreeWithAllDeepest solution = new _865_SubtreeWithAllDeepest();
            Assert.AreEqual(2, solution.SubtreeWithAllDeepest(root).val);
        }
    }
}