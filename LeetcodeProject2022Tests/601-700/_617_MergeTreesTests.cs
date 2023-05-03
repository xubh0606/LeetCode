using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._601_700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700.Tests
{
    [TestClass()]
    public class _617_MergeTreesTests
    {
        [TestMethod()]
        public void MergeTreesTest()
        {
            TreeNode root1 = TreeNode.GetTree(new int[] { 1, 3, 2, 5 });
            TreeNode root2 = TreeNode.GetTree(new int[] { 2, 1, 3, -1, 4, -1, 7 });
            _617_MergeTrees solution = new _617_MergeTrees();
            //输出：[3,4,5,5,4,null,7]
            TreeNode root3 = solution.MergeTrees(root1, root2);
            Assert.AreEqual(3, root3.val);
        }
    }
}