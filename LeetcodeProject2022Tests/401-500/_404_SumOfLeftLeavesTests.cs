using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _404_SumOfLeftLeavesTests
    {
        [TestMethod()]
        public void SumOfLeftLeavesTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 9, 20, -1, -1, 15, 7 });
            _404_SumOfLeftLeaves solution = new _404_SumOfLeftLeaves();
            Assert.AreEqual(24, solution.SumOfLeftLeaves(root));
        }
    }
}