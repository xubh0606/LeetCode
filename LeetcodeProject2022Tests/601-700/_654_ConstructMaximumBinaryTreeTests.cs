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
    public class _654_ConstructMaximumBinaryTreeTests
    {
        [TestMethod()]
        public void ConstructMaximumBinaryTreeTest()
        {
            int[] nums = new int[] { 3, 2, 1, 6, 0, 5 };
            _654_ConstructMaximumBinaryTree solution = new _654_ConstructMaximumBinaryTree();
            Assert.AreEqual(6, solution.ConstructMaximumBinaryTree(nums).val);
        }
    }
}