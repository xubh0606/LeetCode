using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProject2022;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _98_IsValidBSTTests
    {
        [TestMethod()]
        public void IsValidBSTTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 2, 1, 3 });
            _98_IsValidBST solution = new _98_IsValidBST();
            Assert.IsTrue(solution.IsValidBST(root));
        }
    }
}