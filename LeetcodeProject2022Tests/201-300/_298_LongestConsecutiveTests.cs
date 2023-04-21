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
    public class _298_LongestConsecutiveTests
    {
        [TestMethod()]
        public void LongestConsecutiveTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, -1, 3, -1, -1, 2, 4, -1, -1, -1, -1, -1, -1, -1, 5 });
            _298_LongestConsecutive solution = new _298_LongestConsecutive();
            Assert.AreEqual(3, solution.LongestConsecutive(root));
        }
    }
}