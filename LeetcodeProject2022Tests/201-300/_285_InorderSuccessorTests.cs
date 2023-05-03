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
    public class _285_InorderSuccessorTests
    {
        [TestMethod()]
        public void InorderSuccessorTest()
        {
            TreeNode root = TreeNode.GetTree(new int[]{ 2, 1, 3});
            TreeNode p = root.left;
            _285_InorderSuccessor solution = new _285_InorderSuccessor();
            Assert.AreEqual(2, solution.InorderSuccessor(root, p).val);
        }
    }
}