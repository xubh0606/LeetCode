using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _100_IsSameTreeTests
    {
        [TestMethod()]
        public void IsSameTreeTest()
        {
            TreeNode p = TreeNode.GetTree(new int[] { 1, 2, 3 });
            TreeNode q = TreeNode.GetTree(new int[] { 1, 2, 3 });
            _100_IsSameTree solution = new _100_IsSameTree();
            Assert.IsTrue(solution.IsSameTree(p, q));
        }
    }
}