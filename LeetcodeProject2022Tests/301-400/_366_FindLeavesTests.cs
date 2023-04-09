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
    public class _366_FindLeavesTests
    {
        [TestMethod()]
        public void FindLeavesTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, 2, 3, 4, 5 });
            _366_FindLeaves solution = new _366_FindLeaves();
            //输出: [[4,5,3],[2],[1]]
            Assert.AreEqual(3, solution.FindLeaves(root));
        }
    }
}